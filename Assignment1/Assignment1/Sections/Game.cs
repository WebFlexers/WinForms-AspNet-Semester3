using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment1.Sections
{
    public partial class Game : UserControl, IResponsive
    {
        public Responsive Responsive { get; set; }
        public Game()
        {
            InitializeComponent();
            Responsive = new Responsive(this);
        }

        public void ResizeUI(Size newSize)
        {
            Responsive.ScaleControls(newSize);
        }

        List<string> ImagePaths { get; set; }
        Player player;

        public bool LoadGame(string username)
        {
            Focus(); // To be able to open escape menu when pressing esc

            GameSettings.IsGameInProgress = true;
            Card.AttemptsNum = 0;
            Card.OpenCardsCount = 0;

            ImagePaths = new List<string>();
            if (LoadImages())
            {
                player = new Player(username);
                timerCountTime.Start();
                return true;
            }
            else
                return false;

        }

        private bool LoadImages()
        {
            // Get all the images from the Image Directory
            var filters = new string[] { "jpg", "jpeg", "png", "gif", "tiff", "bmp", "svg" }; // only get files with these extensions
            try
            {
                foreach (string filter in filters)
                    ImagePaths.AddRange(Directory.GetFiles(GameSettings.ImageDirectory, 
                                        string.Format("*.{0}", filter), SearchOption.AllDirectories));
            } 
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Can't start the game");
                return false;
            }
            
            // Pick 8 random images from the Image Directory
            List<string> randomizedImagePaths = new List<string>();
            Random rnd = new Random((int)DateTime.Now.Ticks);
            if (ImagePaths.Count >= 8)
                randomizedImagePaths = ImagePaths.OrderBy(x => rnd.Next()).Take(8).ToList();
            else
            {
                MessageBox.Show("Not enough images found in the specified directory. Add enough images or change image directory", 
                                "Unable to start", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Add a copy of every photo to the list
            for (int i = 0; i < 8; i++)
                randomizedImagePaths.Add(randomizedImagePaths[i]);

            // Shuffle the photos
            rnd = new Random((int)DateTime.Now.Ticks);
            var finalImagePaths = randomizedImagePaths.OrderBy(x => rnd.Next()).ToList();

            // Save a photo to each card
            int index = 0;
            foreach (Card card in this.Controls.OfType<Card>())
            {
                card.SetImage(finalImagePaths[index]);
                index++;
            }

            return true;
        }

        // Counts the time
        private void timerCountTime_Tick(object sender, EventArgs e)
        {
            player.Time = player.Time.Add(TimeSpan.FromSeconds(1)); // Add one second
            labelTime.Text = player.Time.ToString(@"hh\:mm\:ss");
        }

        // Check the open cards count every time a card opens in order to end the game
        private void pictureBoxCardPaint(object sender, PaintEventArgs e)
        {
            if (Card.OpenCardsCount >= 16)
                FinishGame();
        }

        // Adds player if needed and shows scoreboard
        private void FinishGame()
        {
            timerCountTime.Stop();
            labelTime.Text = "00.00.00";

            //Save the attempts
            player.Tries = Card.AttemptsNum;

            // Reset card properties
            Card.AttemptsNum = 0;
            Card.OpenCardsCount = 0;

            // Add the player on the list or replace him if a worse attemt with the same name already exists
            Player existantPlayer = GameSettings.Players.Find(x => x.Username.Equals(player.Username));
            if (existantPlayer == null)
                GameSettings.Players.Add(player);
            else if (player.Time < existantPlayer.Time)
                existantPlayer = player;

            // Sort players by time (ascending)
            GameSettings.Players.Sort((x, y) => x.Time.CompareTo(y.Time));

            // Serialize the players list
            Serializer.SerializePlayers(GameSettings.Players);

            Sound.FadeInSong(Sound.Song.Victory, 100);

            FormMain form = (FormMain)Application.OpenForms[0];
            form.ShowScoreboard();

            GameSettings.IsGameInProgress = false;
        }

        // Aborts the game
        private void StopGame()
        {
            timerCountTime.Stop();
            labelTime.Text = "00.00.00";
            Card.OpenCardsCount = 0;

            GameSettings.IsGameInProgress = false;
            Card.AttemptsNum = 0;
            Card.OpenCardsCount = 0;
        }

        private void PauseGame()
        {
            timerCountTime.Stop();
        }

        private void UnpauseGame()
        {
            timerCountTime.Start();
        }

        // Shows escape menu
        private void Game_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                PauseGame();
                StopGame stopGame = StopGame;
                FormMask formMask = new FormMask(stopGame);
                formMask.ShowDialog();

                if (GameSettings.IsGameInProgress)
                    UnpauseGame();
            }
        }

        
    }

    public delegate void StopGame();

    class Card : PictureBox
    {
        public string ImagePath { get; set; }
        private bool IsOpen { get; set; }
        public void SetImage(string path)
        {
            // Save the path of the given image
            ImagePath = path;

            // Set the back card as picturebox image
            Image = Properties.Resources.card_back_small;

            // Indicates if the card is open
            IsOpen = false;

            // Events
            Click += OnClick;
        }

        private void OnClick(object sender, EventArgs e)
        {
            if (!IsOpeningInProgress && !this.IsOpen)
                Open();                
        }

        // Open the card and check for pair
        private void Open()
        {
            if (OpenCard != null && OpenCard != this)
            {
                IsCardCorrect();
                AttemptsNum++;
            }
                
            else if (OpenCard == this)
                return; // To avoid playing sound effect if the same card is clicked twice   
            else
                OpenCard = this;

            Image = Image.FromFile(ImagePath);
            Sound.PlayEffect(Sound.Effect.CardFlip);
        }

        private void IsCardCorrect()
        {
            // If 2 cards have the same image they are a pair
            if (OpenCard.ImagePath.Equals(this.ImagePath))
            {
                OpenCardsCount += 2;

                this.IsOpen = true;
                OpenCard.IsOpen = true;
                OpenCard = null;
            }
            else
            {
                // Using thread to avoid freezing the whole application
                // when calling Thread.Sleep()
                Thread closeCardsThread = new Thread(CloseCards);
                closeCardsThread.Start();
            }

        }

        // Replace the photo of non pair cards 
        // with the default card back after a delay
        private void CloseCards()
        {
            IsOpeningInProgress = true;

            Thread.Sleep(400);
            Invoke((Action)(() => this.Image = Properties.Resources.card_back_small));
            Invoke((Action)(() => OpenCard.Image = Properties.Resources.card_back_small));

            OpenCard = null;
            IsOpeningInProgress = false;
        }

        // Used to prevent the user from clicking a new image
        // before the wrong pair is closed
        private static bool IsOpeningInProgress { get; set; } = false;
        // The number of cards currently open
        public static int OpenCardsCount { get; set; }
        // All the attempts
        public static int AttemptsNum { get; set; } = 0;
        // The current open card
        public static Card OpenCard { get; set; }
    }
}

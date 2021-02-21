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

        List<string> ImagePaths { get; set; } = new List<string>();

        public bool LoadImages()
        {
            try
            {
                ImagePaths = Directory.GetFiles(GameSettings.ImageDirectory, "*", SearchOption.AllDirectories).ToList();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Warning");
                return false;
            }

            List<string> randomizedImagePaths = new List<string>();
            Random rnd = new Random((int)DateTime.Now.Ticks);
            if (ImagePaths.Count >= 8)
            {
                randomizedImagePaths = ImagePaths.OrderBy(x => rnd.Next()).Take(8).ToList();
                //foreach (string path in randomizedImagePaths)
                //    Console.WriteLine(path);
            }
            else
            {
                MessageBox.Show("Not enough images found in the specified directory. Add enough images or change image directory", 
                                "Unable to start", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            for (int i = 0; i < 8; i++)
            {
                randomizedImagePaths.Add(randomizedImagePaths[i]);
            }

            foreach (string path in randomizedImagePaths)
                Console.WriteLine(path);


            rnd = new Random((int)DateTime.Now.Ticks);
            var finalImagePaths = randomizedImagePaths.OrderBy(x => rnd.Next()).ToList();

            int index = 0;
            foreach (Card card in this.Controls.OfType<Card>())
            {
                card.SetImage(finalImagePaths[index]);
                index++;
            }

            return true;
        }
    }

    class Card : PictureBox
    {
        public string ImagePath { get; set; }
        private bool IsOpen { get; set; }
        public void SetImage(string path)
        {
            // Save the path of the given image
            ImagePath = path;

            // Set the back card as background
            Image = Properties.Resources.card_back_small;

            IsOpen = false;

            // Events
            Click += OnClick;
        } 

        private void OnClick(object sender, EventArgs e)
        {
            if (!IsOpeningInProgress && !this.IsOpen) 
                Open();
        }

        
        private void Open()
        {
            Image = Image.FromFile(ImagePath);

            if (OpenCard != null && OpenCard != this)
                IsCardCorrect();
            else if (OpenCard == this)
                return; // To avoid playing sound effect if the same card is clicked twice
            else
                OpenCard = this;

            Sound.PlayEffect(Sound.Effect.CardFlip);
        }

        private void IsCardCorrect()
        {
            if (OpenCard.ImagePath.Equals(this.ImagePath))
            {
                this.IsOpen = true;
                OpenCard.IsOpen = true;

                OpenCard = null;
            }
            else
            {
                Thread closeCardsThread = new Thread(CloseCards);
                closeCardsThread.Start();
            }

        }

        private void CloseCards()
        {
            IsOpeningInProgress = true;

            Thread.Sleep(500);
            Invoke((Action)(() => this.Image = Properties.Resources.card_back_small));
            Invoke((Action)(() => OpenCard.Image = Properties.Resources.card_back_small));

            OpenCard = null;
            IsOpeningInProgress = false;
        }

        private static bool IsOpeningInProgress { get; set; } = false;
        public static Card OpenCard { get; set; }
    }
}

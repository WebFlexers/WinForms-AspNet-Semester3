using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment1.Sections
{
    public partial class Scoreboard : UserControl, IResponsive
    {
        public Responsive Responsive { get; set; }
        public Scoreboard()
        {
            InitializeComponent();
            Responsive = new Responsive(this);
        }

        public void ResizeUI(Size newSize)
        {
            Responsive.ScaleControls(newSize);
        }

        public void LoadScoreboard()
        {
            if (GameSettings.Players.Count > 0)
            {
                champion.LoadChampion(GameSettings.Players[0]);
                champion.Visible = true;
                labelDisplayUsername.Visible = true;

                if (GameSettings.Players.Count > 4)
                    buttonNext.Show();

                LoadPlayers();
            }
        }

        readonly int START_LOCATION_X = 119;
        readonly int START_LOCATION_Y = 428;
        readonly int DISTANCE = 253;
        List<PlayerModel> playerModels = new List<PlayerModel>();
        private void LoadPlayers()
        {
            playerModels = new List<PlayerModel>();
           
            Point nextLocation = new Point(START_LOCATION_X, START_LOCATION_Y);

            int playerCounter = 0;
            for (int i = 1; i < GameSettings.Players.Count; i++)
            {
                PlayerModel model = new PlayerModel();
                model.LoadPlayer(GameSettings.Players[i]);
                model.Location = nextLocation;
                model.Visible = false;

                Responsive.StoreControl(model);
                playerModels.Add(model);
                this.Controls.Add(model);

                playerCounter++;

                if (playerCounter >= 4)
                    nextLocation = playerModels[playerCounter % 4].Location;
                else
                    nextLocation = new Point(DISTANCE * playerCounter + START_LOCATION_X, START_LOCATION_Y);
            }

            ResizeUI(Screen.FromControl(this).Bounds.Size);

            DisplayPlayerModels(0);
        }

        private void DisplayPlayerModels(int startIndex)
        {
            int playerCounter = 0;

            // Make every player model invisible
            foreach (PlayerModel model in this.Controls.OfType<PlayerModel>())
                model.Hide();

            // Show only 4 according to startIndex
            for (int i = startIndex; i < playerModels.Count; i++)
                if (playerCounter < 4)
                {
                    playerModels[i].Show();
                    Console.WriteLine("----------------");
                    Console.WriteLine(playerModels[i].Player.Username);
                    Console.WriteLine("----------------");
                    playerCounter++;
                }
        }

        int startIndex = 0;
        private void buttonNext_Click(object sender, EventArgs e)
        {
            startIndex++;
            DisplayPlayerModels(startIndex);
            
            if (playerModels.Count - startIndex < 4)
                buttonNext.Hide();

            buttonPrev.Show();
        }

        private void buttonPrev_Click(object sender, EventArgs e)
        {
            startIndex--;
            DisplayPlayerModels(startIndex);

            if (startIndex == 0)
                buttonPrev.Hide();
            buttonNext.Show();
        }

        #region Exit Button
        private void pictureBoxExit_Click(object sender, EventArgs e)
        {
            Sound.FadeInSong(Sound.Song.Menu, 750);
            FormMain form = (FormMain)Application.OpenForms[0];
            form.ShowMainMenu();
        }

        private void pictureBoxExit_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxExit.Image = Properties.Resources.button_square_exit_hover;
            Sound.PlayEffect(Sound.Effect.ButtonHover);
        }

        private void pictureBoxExit_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxExit.Image = Properties.Resources.button_square_exit;
        }
        #endregion

    }
}

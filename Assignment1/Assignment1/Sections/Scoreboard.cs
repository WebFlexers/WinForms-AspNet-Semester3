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
            // Remove existing player models
            for (int i = this.Controls.Count - 1; i >= 0 ; i--)
            {
                if (this.Controls[i] is PlayerModel)
                    this.Controls.RemoveAt(i);
            }

            if (GameSettings.Players.Count > 0)
            {
                champion.LoadChampion(GameSettings.Players[0]);
                champion.Visible = true;
                labelDisplayUsername.Visible = true;

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

                if (!this.Controls.Contains(model))
                {
                    Responsive.StoreControl(model);
                    playerModels.Add(model);
                    this.Controls.Add(model);
                } 

                playerCounter++;
                nextLocation = new Point(DISTANCE * playerCounter + START_LOCATION_X, START_LOCATION_Y);
            }

            ResizeUI(Screen.FromControl(this).Bounds.Size);

            DisplayPlayerModels();
        }

        private void DisplayPlayerModels()
        {
            for (int i = 0; i < playerModels.Count; i++)
                playerModels[i].Show();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < playerModels.Count; i++)
                playerModels[i].Left -= DISTANCE + START_LOCATION_X;
        }

        private void buttonPrev_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < playerModels.Count; i++)
                playerModels[i].Left += DISTANCE + START_LOCATION_X;
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

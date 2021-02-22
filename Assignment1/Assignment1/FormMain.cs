using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment1
{
    public partial class FormMain : Form, IResponsive
    {
        public Responsive Responsive { get; set; }
        public FormMain()
        {
            InitializeComponent();
            Responsive = new Responsive(this);
            prevFormWindowState = this.WindowState;
            this.WindowState = FormWindowState.Maximized;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            Sound.PlaySong(Sound.Song.Menu);
        }

        #region Responsiveness
        public void ResizeUI(Size newSize)
        {
            Responsive.ScaleControls(this.Size);
        }

        private void FormMain_ResizeEnd(object sender, EventArgs e)
        {
            ResizeUI(this.Size);
            foreach (Control control in this.Controls)
            {
                IResponsive responsiveControl = control as IResponsive;
                if (responsiveControl != null)
                    responsiveControl.ResizeUI(this.Size);
            }
        }

        FormWindowState prevFormWindowState;
        private void FormMain_SizeChanged(object sender, EventArgs e)
        {
            if (prevFormWindowState != this.WindowState)
            {
                Size size = new Size(Screen.FromControl(this).Bounds.Width, Screen.FromControl(this).Bounds.Height);
                Responsive.ScaleControls(size);
                prevFormWindowState = this.WindowState;

                foreach (Control control in this.Controls)
                {
                    IResponsive responsiveControl = control as IResponsive;
                    if (responsiveControl != null)
                        responsiveControl.ResizeUI(size);
                }
            }
                
        }
        #endregion

        #region Menu Buttons
        // Menu Function
        private void pictureBoxPlay_Click(object sender, EventArgs e)
        {
            login.BringToFront();
        }

        private void pictureBoxScoreboard_Click(object sender, EventArgs e)
        {
            scoreboard.LoadScoreboard();
            Sound.FadeInSong(Sound.Song.Victory, 750);
            scoreboard.BringToFront();
        }

        private void pictureBoxOptions_Click(object sender, EventArgs e)
        {
            options.BringToFront();
        }

        private void pictureBoxExit_Click(object sender, EventArgs e)
        {
            timerFadeOnExit.Start();
        }
        #endregion

        #region Fade Effects
        private void timerFadeOnExit_Tick(object sender, EventArgs e)
        {
            if (this.Opacity > 0)
            {
                this.Opacity -= 0.05;
            }
            else
            {
                timerFadeOnExit.Stop();
                Application.Exit();
            }
        }

        #endregion

        #region Page Control
        public void ShowScoreboard()
        {
            scoreboard.LoadScoreboard();
            scoreboard.BringToFront();
        }

        public void ShowOptions()
        {
            options.BringToFront();
        }

        public void ShowMainMenu()
        {
            panelMenu.BringToFront();
        }

        public void ShowLoginScreen()
        {
            login.BringToFront();
        }

        public void PlayGame(string username)
        {
            if (game.LoadGame(username))
            {
                Sound.FadeInSong(Sound.Song.Game, 1000);
                game.BringToFront();
            }
        }
        #endregion

        #region Button Effects
        // Menu buttons hover and sound effects
        private void pictureBoxPlay_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxPlay.Image = Properties.Resources.button_square_play_hover;
            Sound.PlayEffect(Sound.Effect.ButtonHover);
        }

        private void pictureBoxPlay_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxPlay.Image = Properties.Resources.button_square_play;
        }

        private void pictureBoxScoreboard_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxScoreboard.Image = Properties.Resources.button_square_scoreboard_hover;
            Sound.PlayEffect(Sound.Effect.ButtonHover);
        }

        private void pictureBoxScoreboard_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxScoreboard.Image = Properties.Resources.button_square_scoreboard;
        }

        private void pictureBoxOptions_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxOptions.Image = Properties.Resources.button_square_options_hover;
            Sound.PlayEffect(Sound.Effect.ButtonHover);
        }

        private void pictureBoxOptions_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxOptions.Image = Properties.Resources.button_square_options;
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

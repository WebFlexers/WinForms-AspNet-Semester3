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
    public partial class FormGameMenu : Form
    {   
        StopGame StopGame { get; set; }
        public FormGameMenu(StopGame stopGame)
        {
            InitializeComponent();
            KeyPreview = true; // Used to pass all key events to form before the focused control
            StopGame = stopGame;
        }

        private void FormGameMenu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }

        #region Buttons Functionality
        private void buttonContinue_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonChangeUser_Click(object sender, EventArgs e)
        {
            var userResponse = MessageBox.Show("Are you sure you want change username? Your current progress will be lost",
                                               "Confirmation", MessageBoxButtons.YesNo);

            if (userResponse == DialogResult.Yes)
            {
                Sound.FadeInSong(Sound.Song.Menu, 500);

                StopGame();

                FormMain form = (FormMain)Application.OpenForms[0];
                form.ShowLoginScreen();
                this.Close();
            }
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            var userResponse = MessageBox.Show("Are you sure you want to return to main menu? Your progress will be lost",
                                               "Confirmation", MessageBoxButtons.YesNo);

            if (userResponse == DialogResult.Yes)
            {
                Sound.FadeInSong(Sound.Song.Menu, 750);

                StopGame();

                FormMain form = (FormMain)Application.OpenForms[0];
                form.ShowMainMenu();
                this.Close();
            } 
        }
        #endregion

        private void button_MouseEnter(object sender, EventArgs e)
        {
            Sound.PlayEffect(Sound.Effect.ButtonHover);
        }
    }
}

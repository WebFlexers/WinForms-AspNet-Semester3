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
    public partial class Login : UserControl, IResponsive
    {
        public Responsive Responsive { get; set; }
        public Login()
        {
            InitializeComponent();
            Responsive = new Responsive(this);
        }

        public void ResizeUI(Size newSize)
        {
            Responsive.ScaleControls(newSize);
        }


        #region Buttons Functionality
        // Buttons functionality
        private void pictureBoxPlay_Click(object sender, EventArgs e)
        {
            // Start the game if name isn't empty
            if (string.IsNullOrWhiteSpace(textBoxName.Text))
                MessageBox.Show("Type in a username to continue", "Unable to start",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                FormMain form = (FormMain)Application.OpenForms[0];
                form.PlayGame(textBoxName.Text);
            }
        }

        private void pictureBoxBack_Click(object sender, EventArgs e)
        {
            FormMain form = (FormMain)Application.OpenForms[0];
            form.ShowMainMenu();
        }
        #endregion

        #region Buttons Effects
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

        private void pictureBoxBack_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxBack.Image = Properties.Resources.button_square_back_hover;
            Sound.PlayEffect(Sound.Effect.ButtonHover);
        }

        private void pictureBoxBack_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxBack.Image = Properties.Resources.button_square_back;
        }
        #endregion

    }
}

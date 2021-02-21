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
    public partial class Options : UserControl, IResponsive
    {
        public Responsive Responsive { get; set; }
        public Options()
        {
            InitializeComponent();
            Responsive = new Responsive(this);
            labelPath.Text = GameSettings.ImageDirectory;
        }

        public void ResizeUI(Size newSize)
        {
            Responsive.ScaleControls(newSize);
        }

        private void pictureBoxBrowse_Click(object sender, EventArgs e)
        {
            var userResponse = folderBrowserDialog.ShowDialog();
            if (userResponse == DialogResult.OK)
            {
                GameSettings.ImageDirectory = folderBrowserDialog.SelectedPath;
                labelPath.Text = folderBrowserDialog.SelectedPath;
            }
                
        }

        private void checkBoxMusic_Click(object sender, EventArgs e)
        {
            if (Sound.IsMusicOn)
                Sound.MuteMusic();                
            else
                Sound.UnmuteMusic();

            foreach (Speaker speaker in Speaker.Speakers)
                speaker.SwitchImage();
        }

        private void checkBoxEffects_Click(object sender, EventArgs e)
        {
            if (Sound.AreSoundEffectsOn)
                Sound.MuteEffects();
            else
                Sound.UnmuteEffects();
        }

        private void pictureBoxResetPath_Click(object sender, EventArgs e)
        {
            GameSettings.ResetImagePath();
            labelPath.Text = GameSettings.ImageDirectory;
        }

        private void pictureBoxBack_Click(object sender, EventArgs e)
        {
            FormMain form = (FormMain)Application.OpenForms[0];
            form.SendControlToBack(this);
        }

        // Hover effects
        private void pictureBoxBrowse_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxBrowse.Image = Properties.Resources.button_square_browse_hover;
            Sound.PlayEffect(Sound.Effect.ButtonHover);
        }

        private void pictureBoxBrowse_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxBrowse.Image = Properties.Resources.button_square_browse;
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

        private void pictureBoxResetPath_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxResetPath.Image = Properties.Resources.button_square_reset_hover;
            Sound.PlayEffect(Sound.Effect.ButtonHover);
        }

        private void pictureBoxResetPath_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxResetPath.Image = Properties.Resources.button_square_reset;
        }
    }
}

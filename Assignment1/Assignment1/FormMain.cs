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

        // Menu Function
        private void pictureBoxPlay_Click(object sender, EventArgs e)
        {
            if (game.LoadImages())
            {
                Sound.FadeInSong(Sound.Song.Game);
                game.BringToFront();
            }
        }

        private void pictureBoxOptions_Click(object sender, EventArgs e)
        {
            options.BringToFront();
        }

        private void pictureBoxExit_Click(object sender, EventArgs e)
        {
            timerFadeOnExit.Start();
        }

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

        public void SendControlToBack(Control control)
        {
            control.SendToBack();
        }
        
        public void BringControlToFront(Control control)
        {
            control.BringToFront();
        }

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

        
    }
}

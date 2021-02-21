using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment1
{
    public class Speaker : PictureBox
    {
        // This list is used to give access to all speaker objects created
        // so they can be all accessed at once when the image needs to changed
        public static List<Speaker> Speakers { get; set; } = new List<Speaker>();
        public bool IsSpeakerOn = true;

        public Speaker()
        {
            this.Click += OnClick;
            this.Image = Properties.Resources.speaker_60px;
            Speakers.Add(this);
        }

        private void OnClick(object sender, EventArgs e)
        {
            if (Sound.IsMusicOn)
            {
                Sound.MuteMusic();
            }
            else
            {
                Sound.UnmuteMusic();
            }
            SwitchImage();
        }

        public void SwitchImage()
        {
            if (IsSpeakerOn)
            {
                this.Image = Properties.Resources.mute_60px;
                IsSpeakerOn = false;
            }  
            else
            {
                this.Image = Properties.Resources.speaker_60px;
                IsSpeakerOn = true;
            }
                
        }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Threading.Tasks;
using WMPLib;

namespace Assignment1
{
    public static class Sound
    {
        public static bool IsMusicOn { get; set; } = true;
        public static bool AreSoundEffectsOn { get; set; } = true;

        private static System.Windows.Forms.Timer timerFade = new System.Windows.Forms.Timer();

        static Sound()
        {
            timerFade.Enabled = false;
            timerFade.Interval = 1;
            timerFade.Tick += timerFade_Tick;
        }

        /* Holds the location of every song */
        public class Song
        {
            private Song(string filePath) 
            { 
                Path = filePath;
                Player = new WindowsMediaPlayer();
                if (!IsMusicOn)
                    Player.settings.mute = true;
                Player.settings.volume = 60;
                Player.URL = Path;
                Player.settings.setMode("loop", true);
            }

            // The song location
            public WindowsMediaPlayer Player { get; set; }
            public string Path { get; set; }

            // All songs
            public static Song Menu { get { return new Song(@"Music\menu.mp3"); } }
            public static Song Game { get { return new Song(@"Music\game.mp3"); } }
            public static Song Victory { get { return new Song(@"Music\victory.mp3"); } }
        }

        public class Effect
        {
            private Effect(string filePath)
            {
                Path = filePath;
                Player = new WindowsMediaPlayer();
                Player.settings.volume = 60;
                Player.settings.autoStart = false;
                Player.URL = Path;
                Player.settings.setMode("loop", false);
            }

            // The song location
            public WindowsMediaPlayer Player { get; set; }
            public string Path { get; set; }

            // All effects
            public static Effect ButtonHover { get { return new Effect(@"SoundEffects\button_hover_sound.mp3"); } }
            public static Effect CardTouch { get { return new Effect(@"SoundEffects\card_touch.wav"); } }
            public static Effect CardFlip { get { return new Effect(@"SoundEffects\card_flip.wav"); } }
        }

        /* Plays the jazz song */
        static Song currentSong;
        static Song requestedSong;
        public static void PlaySong(Song song)
        {
            if (currentSong != null)
                currentSong.Player.controls.stop();

            requestedSong = song;
            currentSong = song;

            requestedSong.Player.controls.play();
        }

        public static void FadeInSong(Song song, int duration)
        {
            requestedSong = song;
            requestedSong.Player.settings.volume = 0;

            timerFade.Interval = duration / 100; // Because max volume is 100
            timerFade.Start();
        }

        private static void timerFade_Tick(object sender, EventArgs e)
        {
            if (requestedSong.Player.settings.volume < 100)
            {
                requestedSong.Player.settings.volume += 1;
                if (currentSong != null)
                    currentSong.Player.settings.volume -= 1;
            }
            else
            {
                timerFade.Stop();
                currentSong = requestedSong;
            }
        } 

        public static void PlayEffect(Effect effect)
        {
            if (AreSoundEffectsOn)
                effect.Player.controls.play();
        }

        public static void MuteMusic()
        {
            if (currentSong != null)
                currentSong.Player.settings.mute = true;
            if (requestedSong != null)
                requestedSong.Player.settings.mute = true;
            IsMusicOn = false;
        }

        public static void UnmuteMusic()
        {
            if (currentSong != null)
                currentSong.Player.settings.mute = false;
            if (requestedSong != null)
                requestedSong.Player.settings.mute = false;
            IsMusicOn = true;
        }

        public static void MuteEffects()
        {
            AreSoundEffectsOn = false;
        }

        public static void UnmuteEffects()
        {
            AreSoundEffectsOn = true;
        }
    }

    
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public static class GameSettings
    {
        public static string ImageDirectory;
        public static List<Player> Players { get; set; } = new List<Player>();
        public static bool IsGameInProgress { get; set; } = false;

        static GameSettings()
        {
            ImageDirectory = Path.Combine(Directory.GetCurrentDirectory(), "Images");
            //for (int i = 1; i <= 10; i++)
            //{
            //    Players.Add(new Player("Jack"+i, i+9, new TimeSpan(i, i, i)));
            //}
        }

        public static void ResetImagePath()
        {
            ImageDirectory = Path.Combine(Directory.GetCurrentDirectory(), "Images");
        }
    }
}

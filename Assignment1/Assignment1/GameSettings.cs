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

        static GameSettings()
        {
            ImageDirectory = Path.Combine(Directory.GetCurrentDirectory(), "Images");
        }

        public static void ResetImagePath()
        {
            ImageDirectory = Path.Combine(Directory.GetCurrentDirectory(), "Images");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    [Serializable]
    public class Player
    {
        public string Username { get; set; }
        public int Tries { get; set; }
        public TimeSpan Time { get; set; }

        public Player(string username) 
        {
            Username = username;
            Tries = 0;
            Time = TimeSpan.FromTicks(0);
        }
        public Player(string username, int tries, TimeSpan time)
        {
            Username = username;
            Tries = tries;
            Time = time;
        }
    }
}

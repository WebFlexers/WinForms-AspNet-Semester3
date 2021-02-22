using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment1
{
    public partial class Champion : UserControl
    {
        public Player Player { get; set; }
        public Champion()
        {
            InitializeComponent();
        }

        public void LoadChampion(Player player)
        {
            Player = player;
            labelUsername.Text = player.Username;
            labelTries.Text = player.Tries.ToString();
            labelTime.Text = player.Time.ToString(@"hh\:mm\:ss");
        }
    }
}

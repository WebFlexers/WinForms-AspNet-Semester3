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
    public partial class PlayerModel : UserControl
    {
        public Player Player { get; set; }

        public PlayerModel()
        {
            InitializeComponent();
        }

        public void LoadPlayer(Player player)
        {
            Player = player;
            labelUsername.Text = Player.Username;
            labelTries.Text = Player.Tries.ToString();
            labelTime.Text = Player.Time.ToString(@"hh\:mm\:ss");
        }
    }
}

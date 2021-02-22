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
    public partial class FormMask : Form
    {
        StopGame StopGame { get; set; }
        public FormMask(StopGame stopGame)
        {
            InitializeComponent();
            StopGame = stopGame;
        }

        private void FormMask_Load(object sender, EventArgs e)
        {
            FormGameMenu form = new FormGameMenu(StopGame);
            form.FormClosed += new FormClosedEventHandler((senderObj, eventArgs) => this.Close());
            form.ShowDialog();
        }
    }
}

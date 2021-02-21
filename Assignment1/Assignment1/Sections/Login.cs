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
    public partial class Login : UserControl, IResponsive
    {
        public Responsive Responsive { get; set; }
        public Login()
        {
            InitializeComponent();
            Responsive = new Responsive(this);
        }

        public void ResizeUI(Size newSize)
        {
            Responsive.ScaleControls(newSize);
        }
    }
}

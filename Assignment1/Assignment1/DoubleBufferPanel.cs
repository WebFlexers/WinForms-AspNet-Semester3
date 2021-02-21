using System.Windows.Forms;

namespace Assignment1
{
    // To minimize flickering
    public class DoubleBufferPanel : Panel
    {
        public DoubleBufferPanel()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            UpdateStyles();
        }
    }
}

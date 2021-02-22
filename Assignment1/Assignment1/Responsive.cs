using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment1
{
    public class Responsive
    {
        Size initialContainerSize;
        Control.ControlCollection controls;
        Dictionary<Control, Size> initialControlSizes = new Dictionary<Control, Size>();
        
        public Responsive(Form form)
        {
            initialContainerSize = form.Size;
            controls = form.Controls;
            InitializeControlSizes();
        }

        public Responsive(Panel panel)
        {
            initialContainerSize = panel.Size;
            controls = panel.Controls;
            InitializeControlSizes();
        }

        public Responsive(UserControl userControl)
        {
            initialContainerSize = userControl.Size;
            controls = userControl.Controls;
            InitializeControlSizes();
        }

        private class Ratio
        {
            public double Value { get; set; }

            public Ratio(double initialValue, double finalValue)
            {
                Value = initialValue / finalValue;
            }
        }

        Dictionary<Control, Ratio> controlToContainerWidthRatios = new Dictionary<Control, Ratio>();
        Dictionary<Control, Ratio> controlToContainerHeightRatios = new Dictionary<Control, Ratio>();
        Dictionary<Control, Ratio> controlToContainerXRatios = new Dictionary<Control, Ratio>();
        Dictionary<Control, Ratio> controlToContainerYRatios = new Dictionary<Control, Ratio>();

        private void InitializeControlSizes()
        {
            Store(controls);
        }

        private void Store(Control.ControlCollection controlCollection)
        {
            foreach (Control control in controlCollection)
            {
                StoreControl(control);

                if (control is Panel)
                    Store(control.Controls);
            }
        }

        public void StoreControl(Control control)
        {
            initialControlSizes.Add(control, control.Size);

            Ratio controlToContainerWidth = new Ratio(control.Width, initialContainerSize.Width);
            Ratio controlToContainerHeight = new Ratio(control.Height, initialContainerSize.Height);
            controlToContainerWidthRatios.Add(control, controlToContainerWidth);
            controlToContainerHeightRatios.Add(control, controlToContainerHeight);

            Ratio controlToContainerX = new Ratio(control.Left, initialContainerSize.Width);
            Ratio controlToContainerY = new Ratio(control.Top, initialContainerSize.Height);
            controlToContainerXRatios.Add(control, controlToContainerX);
            controlToContainerYRatios.Add(control, controlToContainerY);
        }

        public void ScaleControls(Size newSize)
        {
            Scale(newSize, controls);
        }

        private void Scale (Size newSize, Control.ControlCollection controlCollection)
        {
            foreach (Control control in controlCollection)
            {
                control.Width = Convert.ToInt32((double)newSize.Width * controlToContainerWidthRatios[control].Value);
                control.Height = Convert.ToInt32((double)newSize.Height * controlToContainerHeightRatios[control].Value);
                control.Left = Convert.ToInt32((double)newSize.Width * controlToContainerXRatios[control].Value);
                control.Top = Convert.ToInt32((double)newSize.Height * controlToContainerYRatios[control].Value);

                if (control is Panel)
                    Scale(newSize, control.Controls);
            }
        }
    }

    public interface IResponsive
    {
        Responsive Responsive { get; set; }
        void ResizeUI(Size newSize);
    }
}

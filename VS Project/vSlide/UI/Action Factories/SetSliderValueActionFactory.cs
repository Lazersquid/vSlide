using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vSlide
{
    public partial class SetSliderValueActionFactory : UserControl, ISliderActionFactory
    {
        public Control Control { get { return this; } }

        public SetSliderValueActionFactory()
        {
            InitializeComponent();
        }

        public ISliderAction CreateAction()
        {
            return new SetSliderValueAction(deltaDecimalControl.Value / 100);
        }
    }
}

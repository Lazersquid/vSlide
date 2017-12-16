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
    public partial class WhenKeyPressedTriggerFactory : UserControl, ISliderTriggerFactory
    {
        public Control Control { get { return this; } }

        public WhenKeyPressedTriggerFactory()
        {
            InitializeComponent();
        }

        public ISliderTrigger CreateTrigger()
        {
            return new WhenKeyPressedTrigger(keyBindControl.KeyBind);
        }
    }
}

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
    public partial class WhileKeyPressedTriggerFactory : UserControl, ISliderTriggerFactory
    {
        public Control Control { get { return this; } }

        public WhileKeyPressedTriggerFactory()
        {
            InitializeComponent();
        }

        public ISliderTrigger CreateTrigger()
        {
            return new WhileKeyPressedTrigger(keyBindControl.KeyBind, decimal.ToInt32(tresholdDecimalControl.Value), decimal.ToInt32(intervalDecimalControl.Value));
        }

        public void SubscribeToRebindInitializationCallback(RebindInitializeHandler initializeRebindCallback)
        {
            keyBindControl.SubscribeToRebindInitializationCallback(initializeRebindCallback);
        }

        public void UnsubscribeFromRebindInitializationCallback(RebindInitializeHandler initializeRebindCallback)
        {
            keyBindControl.UnsubscribeFromRebindInitializationCallback(initializeRebindCallback);
        }
    }
}

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
    public partial class WhileKeyPressedTriggerFactory : UserControl, ISliderTriggerFactory, IRebindable
    {
        public Control Control { get { return this; } }

        public KeyBind KeyBind
        {
            get { return keyBindControl.KeyBind; }
            set
            {
                keyBindControl.KeyBind = value ?? throw new ArgumentNullException();
            }
        }

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

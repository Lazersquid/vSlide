using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vSlide
{
    public class WhenKeyPressedTrigger : KeyBindTrigger
    {
        #region fields that aren't serialized
        protected bool wasKeyBindPressedLastTick;
        #endregion

        public WhenKeyPressedTrigger(KeyBind keyBind)
            : base(keyBind)
        {
            wasKeyBindPressedLastTick = false;
        }

        public override bool IsTriggered(UpdateInformation updateInfo)
        {
            var result = !wasKeyBindPressedLastTick && keyBind.IsDown();
            wasKeyBindPressedLastTick = keyBind.IsDown();
            return result;
        }
    }
}

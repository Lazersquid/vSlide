using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vSlide
{
    public class WhenKeyReleasedTrigger : KeyBindTrigger
    {
        public int MaxPressTime { get; }

        #region fields that aren't serialized
        protected bool wasKeyBindPressedLastTick;
        protected int pressTime;
        #endregion

        public WhenKeyReleasedTrigger(KeyBind keyBind, int maxPressTime)
            : base(keyBind)
        {
            MaxPressTime = maxPressTime;
            wasKeyBindPressedLastTick = false;
            pressTime = 0;
        }

        public override bool IsTriggered(UpdateInformation updateInfo)
        {
            var isKeyBindDown = keyBind.IsDown();
            var result = false;

            if(isKeyBindDown)
            {
                pressTime = Math.Min(pressTime + updateInfo.ElapsedMs, MaxPressTime + 1);
            }
            else
            {
                result = wasKeyBindPressedLastTick && pressTime <= MaxPressTime;
                pressTime = 0;
            }

            wasKeyBindPressedLastTick = isKeyBindDown;
            return result;
        }
    }
}

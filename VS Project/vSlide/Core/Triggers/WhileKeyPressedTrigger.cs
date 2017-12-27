using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vSlide
{
    public class WhileKeyPressedTrigger : KeyBindTrigger
    {
        #region serialized fields
        protected readonly int treshold;
        protected readonly int interval;
        #endregion

        #region fields that aren't serialized
        protected int pressTime;
        #endregion

        public WhileKeyPressedTrigger(KeyBind keyBind, int treshold, int interval)
            : base(keyBind)
        {
            pressTime = 0;
            this.treshold = treshold;
            this.interval = interval;
        }

        public override bool IsTriggered(UpdateInformation updateInfo)
        {
            pressTime = keyBind.IsDown() ? pressTime + updateInfo.ElapsedMs : 0;

            if(pressTime >= treshold + interval)
            {
                pressTime -= interval;
                return true;
            }

            return false;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vSlide
{
    abstract public class KeyBindTrigger : ISliderTrigger
    {
        protected readonly KeyBind keyBind;

        public KeyBindTrigger(KeyBind keyBind)
        {
            if (keyBind == null)
                throw new ArgumentNullException();

            this.keyBind = keyBind;
        }

        public abstract bool IsTriggered(UpdateInformation updateInfo);
    }
}

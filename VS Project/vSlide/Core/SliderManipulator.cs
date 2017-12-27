using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vSlide
{
    public class SliderManipulator
    {
        #region methods
        protected readonly ISliderTrigger trigger;
        protected readonly ISliderAction action;

        public SliderManipulator(ISliderTrigger trigger, ISliderAction action)
        {
            this.trigger = trigger ?? throw new ArgumentNullException(nameof(trigger));
            this.action = action ?? throw new ArgumentNullException(nameof(action));
        }

        public void Execute(UpdateInformation updateInfo)
        {
            if (trigger.IsTriggered(updateInfo))
                action.Execute(updateInfo);
        }
        #endregion
    }
}

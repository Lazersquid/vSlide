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
            if (trigger == null) throw new ArgumentNullException(nameof(trigger));
            if (action == null) throw new ArgumentNullException(nameof(action));

            this.trigger = trigger;
            this.action = action;
        }

        public void Execute(UpdateInformation updateInfo)
        {
            if (trigger.IsTriggered(updateInfo))
                action.Execute(updateInfo);
        }
        #endregion
    }
}

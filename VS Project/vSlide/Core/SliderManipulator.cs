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

        /// <summary>
        /// Executes slider action if slider trigger is fired
        /// </summary>
        /// <param name="updateInfo"></param>
        /// <returns> Whether the trigger of the manipulator fired or not. </returns>
        public bool Execute(UpdateInformation updateInfo)
        {
            if (trigger.IsTriggered(updateInfo))
            {
                action.Execute(updateInfo);
                return true;
            }

            return false;
        }
        #endregion
    }
}

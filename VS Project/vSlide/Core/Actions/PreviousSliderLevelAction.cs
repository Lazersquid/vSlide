using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vSlide
{
    public class PreviousSliderLevelAction : ISliderAction
    {
        public PreviousSliderLevelAction()
        {
        }

        public void Execute(UpdateInformation updateInfo)
        {
            // returns if current slider value is smaller than smallest slider level
            if (updateInfo.SliderLevels.Length <= 0
                || updateInfo.SliderValueAbs < updateInfo.ToAbs(updateInfo.SliderLevels[0]))
                return;

            for(int i = updateInfo.SliderLevels.Length - 1; i >= 0; i--)
            {
                var absSliderLevelValue = updateInfo.ToAbs(updateInfo.SliderLevels[i]);
                if (absSliderLevelValue < updateInfo.SliderValueAbs)
                {
                    updateInfo.SliderValueAbs = absSliderLevelValue;
                    return;
                }
            }
        }
    }
}

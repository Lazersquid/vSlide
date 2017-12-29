using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vSlide
{
    public class NextSliderLevelAction : ISliderAction
    {
        public NextSliderLevelAction()
        {
        }

        public void Execute(UpdateInformation updateInfo)
        {
            // returns if current slider value is greater than highest slider level
            if (updateInfo.SliderLevels.Length <= 0
                || updateInfo.SliderValueAbs >= updateInfo.ToAbs(updateInfo.SliderLevels[updateInfo.SliderLevels.Length - 1]))
                return;

            for(int i = 0; i < updateInfo.SliderLevels.Length; i++)
            {
                var absSliderLevelValue = updateInfo.ToAbs(updateInfo.SliderLevels[i]);
                if (absSliderLevelValue > updateInfo.SliderValueAbs)
                {
                    updateInfo.SliderValueAbs = absSliderLevelValue;
                    return;
                }
            }
        }
    }
}

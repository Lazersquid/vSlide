using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vSlide
{
    public class ModifySliderValueAction : ISliderAction
    {
        public decimal SliderDelta { get; }

        public ModifySliderValueAction(decimal sliderDelta)
        {
            sliderDelta = Math.Max(sliderDelta, -1);
            sliderDelta = Math.Min(sliderDelta, 1);
            SliderDelta = sliderDelta;
        }

        public void Execute(UpdateInformation updateInfo)
        {
            updateInfo.SliderValue += SliderDelta;
        }
    }
}

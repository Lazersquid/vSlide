using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vSlide
{
    public class ModifySliderValueAction : ISliderAction
    {
        private readonly decimal sliderDelta;
        public decimal SliderDelta
        {
            get { return sliderDelta; }
        }

        public ModifySliderValueAction(decimal sliderDelta)
        {
            sliderDelta = Math.Max(sliderDelta, -1);
            sliderDelta = Math.Min(sliderDelta, 1);
            this.sliderDelta = sliderDelta;
        }

        public void Execute(UpdateInformation updateInfo)
        {
            updateInfo.SliderValue += SliderDelta;
        }
    }
}

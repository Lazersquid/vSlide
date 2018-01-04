using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vSlide
{
    public class SetSliderValueAction : ISliderAction
    {
        public decimal SliderValue { get; }
        
        public SetSliderValueAction(decimal sliderValue)
        {
            sliderValue = Math.Max(sliderValue, 0);
            sliderValue = Math.Min(sliderValue, 100);
            SliderValue = sliderValue;
        }

        public void Execute(UpdateInformation updateInfo)
        {
            updateInfo.SliderValue = SliderValue;
        }
    }
}

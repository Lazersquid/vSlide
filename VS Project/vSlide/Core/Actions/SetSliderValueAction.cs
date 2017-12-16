using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vSlide
{
    public class SetSliderValueAction : ISliderAction
    {
        private readonly decimal sliderValue;
        public decimal SliderValue
        {
            get { return sliderValue; }
        }
        
        public SetSliderValueAction(decimal sliderValue)
        {
            sliderValue = Math.Max(sliderValue, 0);
            sliderValue = Math.Min(sliderValue, 100);
            this.sliderValue = sliderValue;
        }

        public void Execute(UpdateInformation updateInfo)
        {
            updateInfo.SliderValue = SliderValue;
        }
    }
}

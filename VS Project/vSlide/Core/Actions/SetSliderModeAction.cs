using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vSlide
{
    public class SetSliderModeAction : ISliderAction
    {
        public ISliderMode SliderMode { get; }

        public SetSliderModeAction(ISliderMode sliderMode)
        {
            SliderMode = sliderMode;
        }

        public void Execute(UpdateInformation updateInfo)
        {
            updateInfo.SliderMode = SliderMode;
        }
    }
}

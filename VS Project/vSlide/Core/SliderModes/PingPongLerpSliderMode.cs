using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vSlide
{
    public class PingPongLerpSliderMode : ISliderMode
    {
        public int TickInterval { get; }
        public decimal SpeedAsFactor { get; }
        public string DisplayString
        {
            get { return "Ping-pong interpolation"; }
        }

        #region don't serialize
        protected bool isLerpingToMax;
        #endregion

        public PingPongLerpSliderMode(int tickInterval, decimal speedAsFactor)
        {
            TickInterval = tickInterval;
            SpeedAsFactor = speedAsFactor;
            isLerpingToMax = true;
        }

        public void Execute(UpdateInformation info)
        {
            if ((isLerpingToMax && info.SliderValueAbs >= info.MaxSliderValueAbs)
                || !isLerpingToMax && info.SliderValueAbs <= 0)
                isLerpingToMax = !isLerpingToMax;
            
            info.SliderValue += isLerpingToMax ? SpeedAsFactor : -SpeedAsFactor;
        }
    }
}

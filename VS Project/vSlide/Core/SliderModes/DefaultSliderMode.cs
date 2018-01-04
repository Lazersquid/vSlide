using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vSlide
{
    public class DefaultSliderMode : ISliderMode
    {
        public int TickInterval { get; }

        public string DisplayString
        {
            get { return "Default"; }
        }

        public DefaultSliderMode()
        {
            TickInterval = int.MaxValue;
        }

        public void Execute(UpdateInformation info)
        {
        }
    }
}

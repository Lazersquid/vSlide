using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vSlide
{
    public interface ISliderMode : IHasDisplayString
    {
        int TickInterval { get; }
        void Execute(UpdateInformation info);
    }
}

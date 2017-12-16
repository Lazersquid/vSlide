using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vSlide
{
    public interface ISliderTrigger
    {
        bool IsTriggered(UpdateInformation updateInfo);
    }
}

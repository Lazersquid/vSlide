using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vSlide
{
    public interface ISliderActionFactory : IControl
    {
        ISliderAction CreateAction();
    }
}
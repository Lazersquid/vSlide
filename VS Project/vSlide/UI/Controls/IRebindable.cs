using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vSlide
{
    public interface IRebindable
    {
        KeyBind KeyBind { get; set; }
    }
}

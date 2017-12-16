using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vSlide
{
    public class VjoyDeviceException : Exception
    {
        public VjoyDeviceException()
        {
        }

        public VjoyDeviceException(string message)
            : base(message)
        {
        }
    }
}

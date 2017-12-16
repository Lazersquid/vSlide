using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vSlide
{
    class LoggingException : Exception
    {
        public LoggingException(string msg, Exception innerException)
            : base(msg, innerException)
        {
        }
    }
}

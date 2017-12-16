using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vSlide
{
    public class KeyValueOutOfRangeException : ArgumentException
    {
        public KeyValueOutOfRangeException(Keys key)
            : base(CreateMsg(key, ""))
        {
        }

        public KeyValueOutOfRangeException(Keys key, string additionalInfo)
            : base(CreateMsg(key, additionalInfo))
        {
        }

        private static string CreateMsg(Keys key, string additionalInfo)
        {
            string msgPrefix = string.Format("Key {0} is out of range!", key);
            return additionalInfo == null || additionalInfo == "" ? msgPrefix : msgPrefix + " " + additionalInfo;
        }
    }
}

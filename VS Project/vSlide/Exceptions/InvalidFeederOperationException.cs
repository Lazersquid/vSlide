using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vSlide
{
    public class InvalidFeederOperationException : Exception
    {
        public InvalidFeederOperationException(FeederState state)
            : base(CreateMsg(state, ""))
        {
        }
        public InvalidFeederOperationException(FeederState state, string additionalInfo)
            : base(CreateMsg(state, additionalInfo))
        {
        }

        private static string CreateMsg(FeederState state, string additionalInfo)
        {
            string msgPrefix = string.Format("Feeder is in state '{0}'!", state);
            return additionalInfo == null || additionalInfo == "" ? msgPrefix : msgPrefix + " " + additionalInfo;
        }
    }
}

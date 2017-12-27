using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vSlide
{
    public class Factory <T>
    {
        #region fields
        protected readonly FactoryHandler factoryHandler;
        protected readonly string message;
        #endregion

        public delegate T FactoryHandler();

        public Factory(FactoryHandler factoryHandler, string toStringString)
        {
            message = toStringString;
            this.factoryHandler = factoryHandler;
        }

        public T CreateInstance()
        {
            return factoryHandler.Invoke();
        }

        public override string ToString()
        {
            return message;
        }
    }
}

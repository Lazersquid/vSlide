using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vSlide
{
    public class Factory <T> : IHasDisplayString
    {
        #region fields
        public string DisplayString { get; }
        protected FactoryHandler factoryHandler { get; }
        #endregion

        public delegate T FactoryHandler();

        public Factory(FactoryHandler factoryHandler, string displayString)
        {
            DisplayString = displayString;
            this.factoryHandler = factoryHandler;
        }

        public T CreateInstance()
        {
            return factoryHandler.Invoke();
        }
    }
}

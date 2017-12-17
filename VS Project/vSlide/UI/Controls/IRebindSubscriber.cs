using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vSlide
{
    public delegate void RebindInitializeHandler(IRebindable sender);

    public interface IRebindSubscriber
    {
        void SubscribeToRebindInitializationCallback(RebindInitializeHandler initializeRebindCallback);
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LEM.Core.Attributes;
using LEM.Core.PubSub;
using LEM.Core.PubSub.Events;
using TinyMessenger;

namespace LEM.Managers.Managers
{
    [Manager]
    public class EmailManager : IManager
    {
        public void Startup()
        {
            var hub = MessageHub.Hub;

            hub.Subscribe<SampleBadgeCompleted>(e =>
            {
                var message = string.Format("{0} : {1}", e.BadgeName, e.User);
                Debug.Print(message);
            });
        }
    }
}

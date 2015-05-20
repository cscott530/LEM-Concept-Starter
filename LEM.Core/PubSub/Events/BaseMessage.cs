using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TinyMessenger;

namespace LEM.Core.PubSub.Events
{
    public class BaseMessage : ITinyMessage
    {
        public object Sender { get; private set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TinyMessenger;

namespace LEM.Core.PubSub
{
    public class MessageHub
    {
        private static TinyMessengerHub _instance;
        public static TinyMessengerHub Hub
        {
            get { return _instance ?? (_instance = new TinyMessengerHub()); }
        }
    }
}

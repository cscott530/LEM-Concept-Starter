using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEM.Core.PubSub.Events
{
    public class SampleBadgeCompleted
    {
        public string User { get; set; }
        public string BadgeName { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace GuldtandMVC_Identity.Models
{
    public partial class OpenHours
    {
        public string DayOfWeek { get; set; }
        public TimeSpan? OpenFrom { get; set; }
        public TimeSpan? OpenTo { get; set; }
        public int RetailChainId { get; set; }

        public virtual RetailChain RetailChain { get; set; }
    }
}

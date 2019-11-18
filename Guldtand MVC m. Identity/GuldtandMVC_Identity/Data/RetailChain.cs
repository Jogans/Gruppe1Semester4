using System;
using System.Collections.Generic;

namespace GuldtandMVC_Identity.Data
{
    public partial class RetailChain
    {
        public RetailChain()
        {
            OpenHours = new HashSet<OpenHours>();
            Product = new HashSet<Product>();
        }

        public int RetailChainId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<OpenHours> OpenHours { get; set; }
        public virtual ICollection<Product> Product { get; set; }
    }
}

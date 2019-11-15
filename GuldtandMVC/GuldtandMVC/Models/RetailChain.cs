using System;
using System.Collections.Generic;

namespace GuldtandMVC.Models
{
    public partial class RetailChain
    {
        public RetailChain()
        {
            Openhours = new HashSet<Openhours>();
            Product = new HashSet<Product>();
        }

        public int RetailChainId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Openhours> Openhours { get; set; }
        public virtual ICollection<Product> Product { get; set; }
    }
}

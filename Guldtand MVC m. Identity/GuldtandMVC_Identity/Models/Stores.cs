using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GuldtandMVC_Identity.Models
{
    public class Stores
    {
        public int StoreId { get; set; }
        public string RetailChain { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Hours { get; set; }

        public virtual RetailChains RetailChainNavigation { get; set; }

    }
}

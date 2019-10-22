using System;
using System.Collections.Generic;

namespace tilbud
{
    public partial class RetailChains
    {
        public RetailChains()
        {
            PrefsChains = new HashSet<PrefsChains>();
            Products = new HashSet<Products>();
            Stores = new HashSet<Stores>();
        }

        public string Name { get; set; }

        public virtual ICollection<PrefsChains> PrefsChains { get; set; }
        public virtual ICollection<Products> Products { get; set; }
        public virtual ICollection<Stores> Stores { get; set; }
    }
}

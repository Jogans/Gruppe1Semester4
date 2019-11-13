using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GuldtandMVC_Identity.Models
{
    public class RetailChains
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

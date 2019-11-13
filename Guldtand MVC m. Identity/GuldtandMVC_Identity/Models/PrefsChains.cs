using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GuldtandMVC_Identity.Models
{
    public class PrefsChains
    {
        public string Username { get; set; }
        public string RetailChain { get; set; }

        public virtual RetailChains RetailChainNavigation { get; set; }
        public virtual ApplicationUser UsernameNavigation { get; set; }
    }
}


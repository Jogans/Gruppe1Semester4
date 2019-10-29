using System;
using System.Collections.Generic;

namespace tilbud
{
    public partial class PrefsChains
    {
        public string Username { get; set; }
        public string RetailChain { get; set; }

        public virtual RetailChains RetailChainNavigation { get; set; }
        public virtual Users UsernameNavigation { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace tilbud
{
    public partial class Users
    {
        public Users()
        {
            PrefsCategories = new HashSet<PrefsCategories>();
            PrefsChains = new HashSet<PrefsChains>();
            Subscriptions = new HashSet<Subscriptions>();
        }

        public string Username { get; set; }
        public string Password { get; set; }

        public virtual ICollection<PrefsCategories> PrefsCategories { get; set; }
        public virtual ICollection<PrefsChains> PrefsChains { get; set; }
        public virtual ICollection<Subscriptions> Subscriptions { get; set; }
    }
}

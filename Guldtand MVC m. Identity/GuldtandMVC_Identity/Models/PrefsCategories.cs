using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GuldtandMVC_Identity.Models
{
    public class PrefsCategories
    {
       
            public string Username { get; set; }
            public string Category { get; set; }

            public virtual ApplicationUser UsernameNavigation { get; set; }
    }

}


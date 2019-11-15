using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace GuldtandMVC_Identity.Models
{
  public class ApplicationUser : IdentityUser
        {
            public ApplicationUser()
            {
                //PrefsCategories = new HashSet<PrefsCategories>();
                //PrefsChains = new HashSet<PrefsChains>();
                //Subscriptions = new HashSet<Subscriptions>();
            }
            [Required]
            [PersonalData]
            public string Username { get; set; }

            

            //public virtual ICollection<PrefsCategories> PrefsCategories { get; set; }
            //public virtual ICollection<PrefsChains> PrefsChains { get; set; }
            //public virtual ICollection<Subscriptions> Subscriptions { get; set; }
        }
    }

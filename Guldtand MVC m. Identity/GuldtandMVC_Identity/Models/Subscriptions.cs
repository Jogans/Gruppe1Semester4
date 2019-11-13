using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GuldtandMVC_Identity.Models
{
    public class Subscriptions
    {
        public string Username { get; set; }
        public int Recipe { get; set; }
        public decimal MaxPrice { get; set; }

        public virtual Recipes RecipeNavigation { get; set; }
        public virtual ApplicationUser UsernameNavigation { get; set; }
    }
}

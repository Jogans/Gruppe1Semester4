using System;
using System.Collections.Generic;

namespace tilbud
{
    public partial class Subscriptions
    {
        public string Username { get; set; }
        public int Recipe { get; set; }
        public decimal MaxPrice { get; set; }

        public virtual Recipes RecipeNavigation { get; set; }
        public virtual Users UsernameNavigation { get; set; }
    }
}

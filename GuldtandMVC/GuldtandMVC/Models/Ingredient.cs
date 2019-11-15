using System;
using System.Collections.Generic;

namespace GuldtandMVC.Models
{
    public partial class Ingredient
    {
        public Ingredient()
        {
            IngredientIngredientlist = new HashSet<IngredientIngredientlist>();
        }

        public int IngredientId { get; set; }
        public string Name { get; set; }
        public decimal? Amount { get; set; }
        public string AmountUnit { get; set; }
        public int? Product { get; set; }

        public virtual Product ProductNavigation { get; set; }
        public virtual ICollection<IngredientIngredientlist> IngredientIngredientlist { get; set; }
    }
}

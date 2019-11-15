using System;
using System.Collections.Generic;

namespace GuldtandMVC.Models
{
    public partial class Ingredient
    {
        public int IngredientId { get; set; }
        public string Name { get; set; }
        public double? Amount { get; set; }
        public string AmountUnit { get; set; }
        public int? Product { get; set; }

        public virtual Product ProductNavigation { get; set; }
    }
}

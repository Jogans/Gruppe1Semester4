using System;
using System.Collections.Generic;

namespace GuldtandMVC.Models
{
    public partial class RecipeIngredientlist
    {
        public int RecipeId { get; set; }
        public int IngredientlistId { get; set; }
        public decimal Amount { get; set; }
        public string AmountUnit { get; set; }

        //public virtual Ingredientlist Ingredientlist { get; set; }
        public virtual Recipe Recipe { get; set; }
    }
}

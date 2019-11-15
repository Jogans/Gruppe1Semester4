using System;
using System.Collections.Generic;

namespace GuldtandMVC.Models
{
    public partial class IngredientIngredientlist
    {
        public int IngredientId { get; set; }
        public int IngredientlistId { get; set; }

        public virtual Ingredient Ingredient { get; set; }
        //public virtual Ingredientlist Ingredientlist { get; set; }
    }
}

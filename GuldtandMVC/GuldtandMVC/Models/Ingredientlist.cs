using System;
using System.Collections.Generic;

namespace GuldtandMVC.Models
{
    public partial class Ingredientlist
    {
        public Ingredientlist()
        {
            IngredientIngredientlist = new HashSet<IngredientIngredientlist>();
            RecipeIngredientlist = new HashSet<RecipeIngredientlist>();
        }

        public int IngredientlistId { get; set; }
        public int? RecipeId { get; set; }

        public virtual Recipe Recipe { get; set; }
        public virtual ICollection<IngredientIngredientlist> IngredientIngredientlist { get; set; }
        public virtual ICollection<RecipeIngredientlist> RecipeIngredientlist { get; set; }
    }
}

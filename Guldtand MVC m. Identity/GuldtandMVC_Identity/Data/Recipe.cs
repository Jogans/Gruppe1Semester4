using System;
using System.Collections.Generic;

namespace GuldtandMVC_Identity.Data
{
    public partial class Recipe
    {
        public Recipe()
        {
            RecipeCategory = new HashSet<RecipeCategory>();
        }

        public int RecipeId { get; set; }
        public string Name { get; set; }
        public string Directions { get; set; }
        public int? Servings { get; set; }
        public double? Price { get; set; }
        public double? SavingsAbsolute { get; set; }

        public virtual IngredientList IngredientList { get; set; }
        public virtual ICollection<RecipeCategory> RecipeCategory { get; set; }
    }
}

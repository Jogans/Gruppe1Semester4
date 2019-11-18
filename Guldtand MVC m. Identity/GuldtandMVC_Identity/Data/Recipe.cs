using System;
using System.Collections.Generic;

namespace GuldtandMVC_Identity.Data
{
    public partial class Recipe
    {
        public Recipe()
        {
            Directions = new HashSet<Directions>();
            RecipeCategory = new HashSet<RecipeCategory>();
        }

        public int RecipeId { get; set; }
        public string Name { get; set; }
        public int? Servings { get; set; }
        public double? Price { get; set; }
        public double? SavingsAbsolute { get; set; }
        public int CookTime { get; set; }
        public string ImgSrc { get; set; }

        public virtual IngredientList IngredientList { get; set; }
        public virtual ICollection<Directions> Directions { get; set; }
        public virtual ICollection<RecipeCategory> RecipeCategory { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace GuldtandMVC.Models
{
    public partial class Recipe
    {
        public Recipe()
        {
            Ingredientlist = new HashSet<Ingredientlist>();
            RecipeCategory = new HashSet<RecipeCategory>();
            RecipeIngredientlist = new HashSet<RecipeIngredientlist>();
        }

        public int RecipeId { get; set; }
        public string Name { get; set; }
        public string Directions { get; set; }
        public int? Servings { get; set; }
        public decimal? Price { get; set; }
        public decimal? SavingsAbsolute { get; set; }

        public virtual ICollection<Ingredientlist> Ingredientlist { get; set; }
        public virtual ICollection<RecipeCategory> RecipeCategory { get; set; }
        public virtual ICollection<RecipeIngredientlist> RecipeIngredientlist { get; set; }
    }
}

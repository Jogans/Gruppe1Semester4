using System;
using System.Collections.Generic;

namespace tilbud
{
    public partial class Recipes
    {
        public Recipes()
        {
            IngredientList = new HashSet<IngredientList>();
            Subscriptions = new HashSet<Subscriptions>();
        }

        public int RecipeId { get; set; }
        public DateTime Timestamp { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string Directions { get; set; }
        public int? Servings { get; set; }
        public decimal? Price { get; set; }
        public decimal? SavingsAbsolute { get; set; }
        public decimal? SavingsPercent { get; set; }

        public virtual ICollection<IngredientList> IngredientList { get; set; }
        public virtual ICollection<Subscriptions> Subscriptions { get; set; }
    }
}

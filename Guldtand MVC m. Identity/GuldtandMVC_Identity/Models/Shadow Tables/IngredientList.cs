using System;
using System.Collections.Generic;

namespace GuldtandMVC_Identity.Data
{
    public partial class IngredientList
    {
        public IngredientList()
        {
            Ingredient = new HashSet<Ingredient>();
        }

        public int IngredientListId { get; set; }
        public int? RecipeId { get; set; }

        public virtual Recipe Recipe { get; set; }
        public virtual ICollection<Ingredient> Ingredient { get; set; }
    }
}

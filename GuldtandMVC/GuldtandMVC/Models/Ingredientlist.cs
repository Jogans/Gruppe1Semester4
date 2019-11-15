using System;
using System.Collections.Generic;

namespace GuldtandMVC.Models
{
    public partial class IngredientList
    {
        public int IngredientListId { get; set; }
        public int? RecipeId { get; set; }

        public virtual Recipe Recipe { get; set; }
    }
}

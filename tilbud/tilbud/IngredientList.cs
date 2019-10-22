using System;
using System.Collections.Generic;

namespace tilbud
{
    public partial class IngredientList
    {
        public int IngredientId { get; set; }
        public int? Recipe { get; set; }
        public string IngredientName { get; set; }
        public decimal Amount { get; set; }
        public string AmountUnit { get; set; }
        public int? ProductRef { get; set; }

        public virtual Products ProductRefNavigation { get; set; }
        public virtual Recipes RecipeNavigation { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace GuldtandMVC_Identity
{
    public partial class Category
    {
        public Category()
        {
            Ingredient = new HashSet<Ingredient>();
            ProductCategory = new HashSet<ProductCategory>();
            RecipeCategory = new HashSet<RecipeCategory>();
        }

        public string CategoryName { get; set; }

        public virtual ICollection<Ingredient> Ingredient { get; set; }
        public virtual ICollection<ProductCategory> ProductCategory { get; set; }
        public virtual ICollection<RecipeCategory> RecipeCategory { get; set; }
    }
}

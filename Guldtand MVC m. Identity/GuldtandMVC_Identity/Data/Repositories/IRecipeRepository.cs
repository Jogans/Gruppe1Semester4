using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GuldtandMVC_Identity.Data.Repositories
{
    interface IRecipeRepository
    {
        IEnumerable<Recipe> GetRecipes();
        void InsertRecipe(Recipe recipe);
        void DeleteRecipe(int recipeId);
        void UpdateRecipe(Recipe recipe);
        void Save();
    }
}

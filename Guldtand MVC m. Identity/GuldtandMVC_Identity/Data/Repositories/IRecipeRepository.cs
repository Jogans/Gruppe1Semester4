using GuldtandMVC_Identity.Data.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GuldtandMVC_Identity.Data.Repositories
{
    interface IRecipeRepository
    {
        Task<IEnumerable<Recipe>> GetRecipes(IQuery<Recipe> query);
        void InsertRecipe(Recipe recipe);
        void DeleteRecipe(int recipeId);
        void UpdateRecipe(Recipe recipe);
        void Save();
    }
}

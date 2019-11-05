using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tilbud;

namespace Transfer
{
    public interface IRecipeRepository : IDisposable
    {
        IEnumerable<Recipes> GetRecipies();
        Recipes GetRecipeByID(int recipeId);
        void InsertRecipe(Recipes recipe);
        void DeleteRecipe(int recipeID);
        void UpdateRecipe(Recipes recipe);
        void Save();

    }
}

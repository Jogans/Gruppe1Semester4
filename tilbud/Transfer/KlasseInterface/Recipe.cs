using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tilbud;

namespace Transfer.KlasseInterface
{
    public class RecipeRepository : IRecipeRepository, IDisposable
    {
        private prj4databaseContext context;

        public StudentRepository(RecipeContext context)
        {
            this.context = context;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Recipes> GetRecipies()
        {
            throw new NotImplementedException();
        }

        public Recipes GetRecipeByID(int recipeId)
        {
            throw new NotImplementedException();
        }

        public void InsertRecipe(Recipes recipe)
        {
            throw new NotImplementedException();
        }

        public void DeleteRecipe(int recipeID)
        {
            throw new NotImplementedException();
        }

        public void UpdateRecipe(Recipes recipe)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}

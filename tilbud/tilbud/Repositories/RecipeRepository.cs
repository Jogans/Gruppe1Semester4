using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using tilbud;

namespace Transfer.Models
{
    public class RecipesRepository : IRecipeRepository, IDisposable
    {
        private prj4databaseContext context;

        public RecipesRepository(prj4databaseContext context)
        {
            this.context = context;
        }

        public IEnumerable<Recipes> GetRecipies()
        {
            return context.Recipes.ToList();
        }

        public Recipes GetRecipeByID(int id)
        {
            return context.Recipes.Find(id);
        }

        public void InsertRecipe(Recipes recipe)
        {
            context.Recipes.Add(recipe);
        }

        public void DeleteRecipe(int recipeID)
        {
            Recipes recipe = context.Recipes.Find(recipeID);
            context.Recipes.Remove(recipe);
        }

        public void UpdateRecipe(Recipes recipe)
        {
            context.Entry(recipe).State = EntityState.Modified;
        }

        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}

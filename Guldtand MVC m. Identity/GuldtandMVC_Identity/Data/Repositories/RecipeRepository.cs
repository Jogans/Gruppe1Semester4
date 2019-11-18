using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GuldtandMVC_Identity.Data.Queries;
using Microsoft.EntityFrameworkCore;


namespace GuldtandMVC_Identity.Data.Repositories
{
    public class RecipeRepository : IRecipeRepository, IDisposable
    {
        private prj4databaseContext context;

        public RecipeRepository(prj4databaseContext context)
        {
            this.context = context;
        }

        public async Task<IEnumerable<Recipe>> GetRecipes(IQuery<Recipe> query)
        {
            return await query.Execute(context);
        }

        public void InsertRecipe(Recipe recipe)
        {
            context.Recipe.Add(recipe);
        }

        public void DeleteRecipe(int recipeId)
        {
            Recipe recipe = context.Recipe.Find(recipeId);
            context.Recipe.Remove(recipe);
        }

        public void UpdateRecipe(Recipe recipe)
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

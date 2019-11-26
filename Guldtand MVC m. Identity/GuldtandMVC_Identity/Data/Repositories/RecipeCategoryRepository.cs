using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GuldtandMVC_Identity.Data.Queries;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace GuldtandMVC_Identity.Data.Repositories
{
    public class RecipeCategoryRepository : IDisposable
    {
        private prj4databaseContext context;

        public RecipeCategoryRepository(prj4databaseContext context)
        {
            this.context = context;
        }

        public async Task<IEnumerable<RecipeCategory>> GetRecipeCategorys(IQuery<RecipeCategory> query)
        {
            return await query.Execute(context);
        }


        public void InsertRecipeCategory(RecipeCategory recipeCategory)
        {
            context.RecipeCategory.Add(recipeCategory);
        }

        public void DeleteRecipeCategory(int recipeCategoryId)
        {
            RecipeCategory recipeCategory = context.RecipeCategory.Find(recipeCategoryId);
            context.RecipeCategory.Remove(recipeCategory);
        }

        public void UpdateRecipeCategory(RecipeCategory recipeCategory)
        {
            context.Entry(recipeCategory).State = EntityState.Modified;
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

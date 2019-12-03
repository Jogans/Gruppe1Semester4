using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using GuldtandMVC_Identity.Data.Queries;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace GuldtandMVC_Identity.Data.Repositories
{
    public class RecipeCategoryRepository : IRepository<RecipeCategory>, IDisposable
    {
        private readonly prj4databaseContext _context;

        public RecipeCategoryRepository(prj4databaseContext context)
        {
            this._context = context;
        }

        public async Task<IEnumerable<RecipeCategory>> Get(IQuery<RecipeCategory> query)
        {
            return await query.Execute(_context);
        }

        public void Insert(RecipeCategory recipeCategory)
        {
            _context.RecipeCategory.Add(recipeCategory);
        }

        public void Delete(int recipeCategoryId)
        {
            RecipeCategory recipeCategory = _context.RecipeCategory.Find(recipeCategoryId);
            _context.RecipeCategory.Remove(recipeCategory);
        }

        public void Update(RecipeCategory recipeCategory)
        {
            _context.Entry(recipeCategory).State = EntityState.Modified;
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        private bool _disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!this._disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this._disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}

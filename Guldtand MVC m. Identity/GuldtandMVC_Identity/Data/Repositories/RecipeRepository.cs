using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using GuldtandMVC_Identity.Data.Queries;
using Microsoft.EntityFrameworkCore;


namespace GuldtandMVC_Identity.Data.Repositories
{
    public class RecipeRepository : IRepository<Recipe>, IDisposable
    {
        private readonly Prj4databaseContext _context;

        public RecipeRepository(Prj4databaseContext context)
        {
            this._context = context;
        }

        public async Task<IEnumerable<Recipe>> Get(IQuery<Recipe> query)
        {
            return await query.Execute(_context);
        }

        public void Insert(Recipe recipe)
        {
            _context.Recipe.Add(recipe);
        }

        public void Delete(int recipeId)
        {
            Recipe recipe = _context.Recipe.Find(recipeId);
            _context.Recipe.Remove(recipe);
        }

        public void Update(Recipe recipe)
        {
            _context.Entry(recipe).State = EntityState.Modified;
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

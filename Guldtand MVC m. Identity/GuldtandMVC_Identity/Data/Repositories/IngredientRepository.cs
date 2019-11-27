using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using GuldtandMVC_Identity.Data.Queries;
using Microsoft.EntityFrameworkCore;

namespace GuldtandMVC_Identity.Data.Repositories
{
    public class IngredientRepository : IRepository<Ingredient>, IDisposable
    {
        private readonly prj4databaseContext _context;

        public IngredientRepository(prj4databaseContext context)
        {
            this._context = context;
        }

        public async Task<IEnumerable<Ingredient>> Get(IQuery<Ingredient> query)
        {
            return await query.Execute(_context);
        }

        public void Insert(Ingredient ingredient)
        {
            _context.Ingredient.Add(ingredient);
        }

        public void Delete(int ingredientId)
        {
            Ingredient ingredient = _context.Ingredient.Find(ingredientId);
            _context.Ingredient.Remove(ingredient);
        }

        public void Update(Ingredient ingredient)
        {
            _context.Entry(ingredient).State = EntityState.Modified;
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

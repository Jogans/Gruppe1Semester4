using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using GuldtandMVC_Identity.Data.Queries;
using Microsoft.EntityFrameworkCore;


namespace GuldtandMVC_Identity.Data.Repositories
{
    public class IngredientListRepository : IRepository<IngredientList>, IDisposable
    {
        private readonly Prj4databaseContext _context;

        public IngredientListRepository(Prj4databaseContext context)
        {
            this._context = context;
        }

        public async Task<IEnumerable<IngredientList>> Get(IQuery<IngredientList> query)
        {
            return await query.Execute(_context);
        }

        public void Insert(IngredientList ingredientList)
        {
            _context.IngredientList.Add(ingredientList);
        }

        public void Delete(int ingredientListId)
        {
            IngredientList ingredientList = _context.IngredientList.Find(ingredientListId);
            _context.IngredientList.Remove(ingredientList);
        }

        public void Update(IngredientList ingredientList)
        {
            _context.Entry(ingredientList).State = EntityState.Modified;
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

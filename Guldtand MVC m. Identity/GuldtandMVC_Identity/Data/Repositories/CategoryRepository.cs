using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using GuldtandMVC_Identity.Data.Queries;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace GuldtandMVC_Identity.Data.Repositories
{
    public class CategoryRepository : IRepository<Category>, IDisposable
    {
        private readonly prj4databaseContext _context;

        public CategoryRepository(prj4databaseContext context)
        {
            this._context = context;
        }

        public async Task<IEnumerable<Category>> Get(IQuery<Category> query)
        {
            return await query.Execute(_context);
        }


        public void Insert(Category category)
        {
            _context.Category.Add(category);
        }

        public void Delete(int categoryId)
        {
            Category category = _context.Category.Find(categoryId);
            _context.Category.Remove(category);
        }

        public void Update(Category category)
        {
            _context.Entry(category).State = EntityState.Modified;
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

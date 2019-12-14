using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using GuldtandMVC_Identity.Data.Queries;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace GuldtandMVC_Identity.Data.Repositories
{
    public class ProductRepository : IRepository<Product>, IDisposable
    {
        private readonly Prj4databaseContext _context;

        public ProductRepository(Prj4databaseContext context)
        {
            this._context = context;
        }

        public async Task<IEnumerable<Product>> Get(IQuery<Product> query)
        {
            return await query.Execute(_context);
        }

        public void Insert(Product product)
        {
            _context.Product.Add(product);
        }

        public void Delete(int productId)
        {
            Product product = _context.Product.Find(productId);
            _context.Product.Remove(product);
        }

        public void Update(Product product)
        {
            _context.Entry(product).State = EntityState.Modified;
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

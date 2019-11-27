using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using GuldtandMVC_Identity.Data.Queries;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace GuldtandMVC_Identity.Data.Repositories
{
    public class ProductCategoryRepository : IRepository<ProductCategory>, IDisposable
    {
        private readonly prj4databaseContext _context;

        public ProductCategoryRepository(prj4databaseContext context)
        {
            this._context = context;
        }

        public async Task<IEnumerable<ProductCategory>> Get(IQuery<ProductCategory> query)
        {
            return await query.Execute(_context);
        }


        public void Insert(ProductCategory productCategory)
        {
            _context.ProductCategory.Add(productCategory);
        }

        public void Delete(int productCategoryId)
        {
            ProductCategory productCategory = _context.ProductCategory.Find(productCategoryId);
            _context.ProductCategory.Remove(productCategory);
        }

        public void Update(ProductCategory productCategory)
        {
            _context.Entry(productCategory).State = EntityState.Modified;
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

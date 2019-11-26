using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GuldtandMVC_Identity.Data.Queries;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace GuldtandMVC_Identity.Data.Repositories
{
    public class ProductCategoryRepository : IDisposable
    {
        private prj4databaseContext context;

        public ProductCategoryRepository(prj4databaseContext context)
        {
            this.context = context;
        }

        public async Task<IEnumerable<ProductCategory>> GetProductCategorys(IQuery<ProductCategory> query)
        {
            return await query.Execute(context);
        }


        public void InsertProductCategory(ProductCategory productCategory)
        {
            context.ProductCategory.Add(productCategory);
        }

        public void DeleteProductCategory(int productCategoryId)
        {
            ProductCategory productCategory = context.ProductCategory.Find(productCategoryId);
            context.ProductCategory.Remove(productCategory);
        }

        public void UpdateProductCategory(ProductCategory productCategory)
        {
            context.Entry(productCategory).State = EntityState.Modified;
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using tilbud.DAL;

namespace tilbud.Repositories
{
    public class ProductsRepository : IProductsRepository, IDisposable
    {
        private prj4databaseContext context;

        public ProductsRepository(prj4databaseContext context)
        {
            this.context = context;
        }

        public IEnumerable<Products> GetProducts()
        {
            return context.Products.ToList();
        }

        public Products GetProductsByID(int id)
        {
            return context.Products.Find(id);
        }

        public void InsertProducts(Products products)
        {
            context.Products.Add(products);
        }

        public void DeleteProducts(int productsID)
        {
            Products products = context.Products.Find(productsID);
            context.Products.Remove(products);
        }

        public void UpdateProducts(Products products)
        {
            context.Entry(products).State = EntityState.Modified;
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tilbud.DAL
{
    public interface IProductsRepository : IDisposable
    {
        IEnumerable<Products> GetProducts();
        Products GetProductsByID(int productsId);
        void InsertProducts(Products products);
        void DeleteProducts(int productsID);
        void UpdateProducts(Products products);
        void Save();
    }
}

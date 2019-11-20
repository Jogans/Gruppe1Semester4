using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GuldtandMVC_Identity.Data.Queries;


namespace GuldtandMVC_Identity.Data.Repositories
{
    interface IProductRepository
    {
        Task<IEnumerable<Product>> GetProducts(IQuery<Product> query);
        //IEnumerable<Product> GetProducts();
        void InsertProduct(Product product);
        void DeleteProduct(int productId);
        void UpdateProduct(Product product);
        void Save();
    }
}

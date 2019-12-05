using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace GuldtandMVC_Identity.Data.Queries
{
    public class ProductQuery  : IQuery<Product>
    {
        public bool LoadRetailChain { get; set; } = false;
        public bool LoadProductCategory { get; set; } = false;
        public string SearchName { get; set; } = "";
        public int NumberOfRecipes { get; set; } = 20;
        public string ValidToDate { get; set; } = "";
        public string[] Stores { get; set; } = new string[8];



        public async Task<IEnumerable<Product>> Execute(prj4databaseContext context)
        {
            List<RetailChain> irrelevantStores = new List<RetailChain>();
            foreach (var store in Stores)
            {
                var dbStore = await context.Set<RetailChain>()
                    .Where(rc => rc.Name.Contains(store))
                    .Take(1)
                    .ToListAsync();
                if (dbStore.Any())
                {
                    irrelevantStores.Add(dbStore.First());
                }
            }

            if (LoadProductCategory == true && LoadRetailChain == false)
            {
                return await context.Set<Product>()
                    .Where(r => r.Name.Contains(SearchName)
                     && r.ValidTo.ToString().Contains(ValidToDate))
                    .OrderBy(p => p.Price)
                    .Include(r => r.ProductCategory)
                    .Take(NumberOfRecipes)
                    .ToListAsync();
            }

            else if (LoadRetailChain == true && LoadProductCategory == false)
            {
                return await context.Set<Product>()
                    .Where(r => r.Name.Contains(SearchName)
                     && r.ValidTo.ToString().Contains(ValidToDate)
                     && !irrelevantStores.Contains(r.RetailChain))
                    .OrderBy(p => p.Price)
                    .Include(r => r.RetailChain)
                    .Take(NumberOfRecipes)
                    .ToListAsync();
            }
            
            else if (LoadProductCategory == true && LoadRetailChain == true)
            {
                return await context.Set<Product>()
                    .Where(r => r.Name.Contains(SearchName)
                     && r.ValidTo.ToString().Contains(ValidToDate)
                     && !irrelevantStores.Contains(r.RetailChain))
                    .OrderBy(p => p.Price)
                    .Include(r => r.RetailChain)
                    .Include(r => r.ProductCategory)
                    .Take(NumberOfRecipes)
                    .ToListAsync();
            }

            else
            {
                return await context.Set<Product>()
                    .Where(r => r.Name.Contains(SearchName)
                     && r.ValidTo.ToString().Contains(ValidToDate))
                    .OrderBy(p => p.Price)
                    .Take(NumberOfRecipes)
                    .ToListAsync();
            }
        }
    }
}

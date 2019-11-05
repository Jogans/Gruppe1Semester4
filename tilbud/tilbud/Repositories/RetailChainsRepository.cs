using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using tilbud.DAL;

namespace tilbud.Repositories
{
    public class RetailChainsRepository : IRetailChainsRepository, IDisposable
    {
        private prj4databaseContext context;

        public RetailChainsRepository(prj4databaseContext context)
        {
            this.context = context;
        }

        public IEnumerable<RetailChains> GetRetailChains()
        {
            return context.RetailChains.ToList();
        }

        public RetailChains GetRetailChainsByID(int id)
        {
            return context.RetailChains.Find(id);
        }

        public void InsertRetailChains(RetailChains retailChains)
        {
            context.RetailChains.Add(retailChains);
        }

        public void DeleteRetailChains(int retailChainsID)
        {
            RetailChains retailChains = context.RetailChains.Find(retailChainsID);
            context.RetailChains.Remove(retailChains);
        }

        public void UpdateRetailChains(RetailChains retailChains)
        {
            context.Entry(retailChains).State = EntityState.Modified;
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

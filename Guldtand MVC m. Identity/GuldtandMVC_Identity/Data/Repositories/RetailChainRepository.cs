using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GuldtandMVC_Identity.Data.Queries;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace GuldtandMVC_Identity.Data.Repositories
{
    public class RetailChainRepository : IDisposable
    {
        private prj4databaseContext context;

        public RetailChainRepository(prj4databaseContext context)
        {
            this.context = context;
        }

        public async Task<IEnumerable<RetailChain>> GetRetailChains(IQuery<RetailChain> query)
        {
            return await query.Execute(context);
        }


        public void InsertRetailChain(RetailChain retailChain)
        {
            context.RetailChain.Add(retailChain);
        }

        public void DeleteRetailChain(int retailChainId)
        {
            RetailChain retailChain = context.RetailChain.Find(retailChainId);
            context.RetailChain.Remove(retailChain);
        }

        public void UpdateRetailChain(RetailChain retailChain)
        {
            context.Entry(retailChain).State = EntityState.Modified;
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

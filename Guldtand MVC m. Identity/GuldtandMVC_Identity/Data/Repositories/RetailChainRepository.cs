using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using GuldtandMVC_Identity.Data.Queries;
using Microsoft.EntityFrameworkCore;

namespace GuldtandMVC_Identity.Data.Repositories
{
    public class RetailChainRepository : IRepository<RetailChain>, IDisposable
    {
        private readonly Prj4databaseContext _context;

        public RetailChainRepository(Prj4databaseContext context)
        {
            this._context = context;
        }

        public async Task<IEnumerable<RetailChain>> Get(IQuery<RetailChain> query)
        {
            return await query.Execute(_context);
        }


        public void Insert(RetailChain retailChain)
        {
            _context.RetailChain.Add(retailChain);
        }

        public void Delete(int retailChainId)
        {
            RetailChain retailChain = _context.RetailChain.Find(retailChainId);
            _context.RetailChain.Remove(retailChain);
        }

        public void Update(RetailChain retailChain)
        {
            _context.Entry(retailChain).State = EntityState.Modified;
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

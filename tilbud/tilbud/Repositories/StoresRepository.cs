using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using tilbud.DAL;

namespace tilbud.Repositories
{
    public class StoresRepository : IStoresRepository, IDisposable
    {
        private prj4databaseContext context;

        public StoresRepository(prj4databaseContext context)
        {
            this.context = context;
        }

        public IEnumerable<Stores> GetStores()
        {
            return context.Stores.ToList();
        }

        public Stores GetStoresByID(int id)
        {
            return context.Stores.Find(id);
        }

        public void InsertStores(Stores stores)
        {
            context.Stores.Add(stores);
        }

        public void DeleteStores(int storesID)
        {
            Stores stores = context.Stores.Find(storesID);
            context.Stores.Remove(stores);
        }

        public void UpdateStores(Stores stores)
        {
            context.Entry(stores).State = EntityState.Modified;
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

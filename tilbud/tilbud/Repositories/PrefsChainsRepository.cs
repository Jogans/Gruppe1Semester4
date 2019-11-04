using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using tilbud.DAL;

namespace tilbud.Repositories
{
    public class PrefsChainRepository : IPrefsChainsRepository, IDisposable
    {
        private prj4databaseContext context;

        public PrefsChainRepository(prj4databaseContext context)
        {
            this.context = context;
        }

        public IEnumerable<PrefsChains> GetPrefsChains()
        {
            return context.PrefsChains.ToList();
        }

        public PrefsChains GetPrefsChainsByID(int id)
        {
            return context.PrefsChains.Find(id);
        }

        public void InsertPrefsChains(PrefsChains prefsChains)
        {
            context.PrefsChains.Add(prefsChains);
        }

        public void DeletePrefsChains(int prefsChainsID)
        {
            PrefsChains prefsChains = context.PrefsChains.Find(prefsChainsID);
            context.PrefsChains.Remove(prefsChains);
        }

        public void UpdatePrefsChains(PrefsChains prefsChains)
        {
            context.Entry(prefsChains).State = EntityState.Modified;
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

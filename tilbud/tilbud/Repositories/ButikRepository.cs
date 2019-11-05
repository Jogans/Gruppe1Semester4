using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using tilbud.DAL;

namespace tilbud.Repositories
{
    public class ButikRepository : IButikRepository, IDisposable
    {
        private prj4databaseContext context;

        public ButikRepository(prj4databaseContext context)
        {
            this.context = context;
        }

        public IEnumerable<Butik> GetButikker()
        {
            return context.Butik.ToList();
        }

        public Butik GetButikByID(int id)
        {
            return context.Butik.Find(id);
        }

        public void InsertButik(Butik butik)
        {
            context.Butik.Add(butik);
        }

        public void DeleteButik(int butikID)
        {
            Butik butik = context.Butik.Find(butikID);
            context.Butik.Remove(butik);
        }

        public void UpdateButik(Butik butik)
        {
            context.Entry(butik).State = EntityState.Modified;
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

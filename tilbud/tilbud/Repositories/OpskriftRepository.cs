using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using tilbud.DAL;

namespace tilbud.Repositories
{
    public class OpskriftRepository : IOpskriftRepository, IDisposable
    {
        private prj4databaseContext context;

        public OpskriftRepository(prj4databaseContext context)
        {
            this.context = context;
        }

        public IEnumerable<Opskrift> GetOpskrifter()
        {
            return context.Opskrift.ToList();
        }

        public Opskrift GetOpskriftByID(int id)
        {
            return context.Opskrift.Find(id);
        }

        public void InsertOpskrift(Opskrift opskrift)
        {
            context.Opskrift.Add(opskrift);
        }

        public void DeleteOpskrift(int opskriftID)
        {
            Opskrift opskrift = context.Opskrift.Find(opskriftID);
            context.Opskrift.Remove(opskrift);
        }

        public void UpdateOpskrift(Opskrift opskrift)
        {
            context.Entry(opskrift).State = EntityState.Modified;
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

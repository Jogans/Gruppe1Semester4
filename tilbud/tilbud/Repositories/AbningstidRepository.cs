using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using tilbud.DAL;

namespace tilbud.Repositories
{
    public class AbningstidRepository : IAbningstidRepository, IDisposable
    {
        private prj4databaseContext context;

        public AbningstidRepository(prj4databaseContext context)
        {
            this.context = context;
        }

        public IEnumerable<Abningstid> GetAbningstider()
        {
            return context.Abningstid.ToList();
        }

        public Abningstid GetAbningstidByID(int id)
        {
            return context.Abningstid.Find(id);
        }

        public void InsertAbningstid(Abningstid abningstid)
        {
            context.Abningstid.Add(abningstid);
        }

        public void DeleteAbningstid(int Id)
        {
            Abningstid abningstid = context.Abningstid.Find(Id);
            context.Abningstid.Remove(abningstid);
        }

        public void UpdateAbningstid(Abningstid abningstid)
        {
            context.Entry(abningstid).State = EntityState.Modified;
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

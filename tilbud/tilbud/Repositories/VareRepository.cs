using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using tilbud;

namespace Transfer.Models
{
    public class VareRepository : IVareRepository, IDisposable
    {
        private prj4databaseContext context;

        public VareRepository(prj4databaseContext context)
        {
            this.context = context;
        }

        public IEnumerable<Vare> GetVarer()
        {
            return context.Vare.ToList();
        }

        public Vare GetVareByID(int id)
        {
            return context.Vare.Find(id);
        }

        public void InsertVare(Vare vare)
        {
            context.Vare.Add(vare);
        }

        public void DeleteVare(int vareID)
        {
            Vare vare = context.Vare.Find(vareID);
            context.Vare.Remove(vare);
        }

        public void UpdateVare(Vare vare)
        {
            context.Entry(vare).State = EntityState.Modified;
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

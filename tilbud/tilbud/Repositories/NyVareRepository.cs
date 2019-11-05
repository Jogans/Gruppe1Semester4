using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using tilbud.DAL;

namespace tilbud.Repositories
{
    public class NyVareRepository : INyVareRepository, IDisposable
    {
        private prj4databaseContext context;

        public NyVareRepository(prj4databaseContext context)
        {
            this.context = context;
        }

        public IEnumerable<NyVare> GetNyVarer()
        {
            return context.NyVare.ToList();
        }

        public NyVare GetNyVareByID(int id)
        {
            return context.NyVare.Find(id);
        }

        public void InsertNyVare(NyVare nyVare)
        {
            context.NyVare.Add(nyVare);
        }

        public void DeleteNyVare(int nyVareID)
        {
            NyVare nyVare = context.NyVare.Find(nyVareID);
            context.NyVare.Remove(nyVare);
        }

        public void UpdateNyVare(NyVare nyVare)
        {
            context.Entry(nyVare).State = EntityState.Modified;
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

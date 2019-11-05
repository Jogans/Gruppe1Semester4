using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using tilbud.DAL;

namespace tilbud.Repositories
{
    public class OpskriftKategoriRepository : IOpskriftKategoriRepository, IDisposable
    {
        private prj4databaseContext context;

        public OpskriftKategoriRepository(prj4databaseContext context)
        {
            this.context = context;
        }

        public IEnumerable<OpskriftKategori> GetOpskriftKategorier()
        {
            return context.OpskriftKategori.ToList();
        }

        public OpskriftKategori GetOpskriftKategoriByID(int id)
        {
            return context.OpskriftKategori.Find(id);
        }

        public void InsertOpskriftKategori(OpskriftKategori opskriftKategori)
        {
            context.OpskriftKategori.Add(opskriftKategori);
        }

        public void DeleteOpskriftKategori(int opskriftKategoriID)
        {
            OpskriftKategori opskriftKategori = context.OpskriftKategori.Find(opskriftKategoriID);
            context.OpskriftKategori.Remove(opskriftKategori);
        }

        public void UpdateOpskriftKategori(OpskriftKategori opskriftKategori)
        {
            context.Entry(opskriftKategori).State = EntityState.Modified;
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

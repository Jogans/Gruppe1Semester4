using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using tilbud.DAL;

namespace tilbud.Repositories
{
    public class KategoriRepository : IKategoriRepository, IDisposable
    {
        private prj4databaseContext context;

        public KategoriRepository(prj4databaseContext context)
        {
            this.context = context;
        }

        public IEnumerable<Kategori> GetKategorier()
        {
            return context.Kategori.ToList();
        }

        public Kategori GetKategoriByID(int id)
        {
            return context.Kategori.Find(id);
        }

        public void InsertKategori(Kategori kategori)
        {
            context.Kategori.Add(kategori);
        }

        public void DeleteKategori(int kategoriID)
        {
            Kategori kategori = context.Kategori.Find(kategoriID);
            context.Kategori.Remove(kategori);
        }

        public void UpdateKategori(Kategori kategori)
        {
            context.Entry(kategori).State = EntityState.Modified;
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using tilbud.DAL;

namespace tilbud.Repositories
{
    public class VareKategoriRepository : IVareKategoriRepository, IDisposable
    {
        private prj4databaseContext context;

        public VareKategoriRepository(prj4databaseContext context)
        {
            this.context = context;
        }

        public IEnumerable<VareKategori> GetVareKategorier()
        {
            return context.VareKategori.ToList();
        }

        public VareKategori GetVareKategoriByID(int id)
        {
            return context.VareKategori.Find(id);
        }

        public void InsertVareKategori(VareKategori vareKategori)
        {
            context.VareKategori.Add(vareKategori);
        }

        public void DeleteVareKategori(int vareKategoriID)
        {
            VareKategori vareKategori = context.VareKategori.Find(vareKategoriID);
            context.VareKategori.Remove(vareKategori);
        }

        public void UpdateVareKategori(VareKategori vareKategori)
        {
            context.Entry(vareKategori).State = EntityState.Modified;
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

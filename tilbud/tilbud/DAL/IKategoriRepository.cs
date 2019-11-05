using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tilbud.DAL
{
    public interface IKategoriRepository : IDisposable
    {
        IEnumerable<Kategori> GetKategorier();
        Kategori GetKategoriByID(int kategoriId);
        void InsertKategori(Kategori kategori);
        void DeleteKategori(int kategoriID);
        void UpdateKategori(Kategori kategori);
        void Save();
    }
}

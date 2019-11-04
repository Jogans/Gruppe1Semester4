using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tilbud.DAL
{
    public interface IVareKategoriRepository : IDisposable
    {
        IEnumerable<VareKategori> GetVareKategorier();
        VareKategori GetVareKategoriByID(int vareKategoriId);
        void InsertVareKategori(VareKategori vareKategori);
        void DeleteVareKategori(int vareKategoriID);
        void UpdateVareKategori(VareKategori vareKategori);
        void Save();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tilbud.DAL
{
    public interface IOpskriftKategoriRepository : IDisposable
    {
        IEnumerable<OpskriftKategori> GetOpskriftKategorier();
        OpskriftKategori GetOpskriftKategoriByID(int opskriftKategoriId);
        void InsertOpskriftKategori(OpskriftKategori opskriftKategori);
        void DeleteOpskriftKategori(int opskriftKategoriID);
        void UpdateOpskriftKategori(OpskriftKategori opskriftKategori);
        void Save();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tilbud.DAL
{
    public interface INyVareRepository : IDisposable
    {
        IEnumerable<NyVare> GetNyVarer();
        NyVare GetNyVareByID(int nyVareId);
        void InsertNyVare(NyVare nyVare);
        void DeleteNyVare(int nyVareID);
        void UpdateNyVare(NyVare nyVare);
        void Save();
    }
}

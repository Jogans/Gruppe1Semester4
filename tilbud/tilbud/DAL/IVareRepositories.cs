using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tilbud;

namespace Transfer
{
    public interface IVareRepository : IDisposable
    {
        IEnumerable<Vare> GetVarer();
        Vare GetVareByID(int vareId);
        void InsertVare(Vare vare);
        void DeleteVare(int vareID);
        void UpdateVare(Vare vare);
        void Save();

    }
}

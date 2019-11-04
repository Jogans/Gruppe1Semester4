using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tilbud.DAL
{
    public interface IButikRepository : IDisposable
    {
        IEnumerable<Butik> GetButikker();
        Butik GetButikByID(int butikId);
        void InsertButik(Butik butik);
        void DeleteButik(int butikID);
        void UpdateButik(Butik butik);
        void Save();
    }
}

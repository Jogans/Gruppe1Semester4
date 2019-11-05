using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tilbud.DAL
{
    public interface IOpskriftRepository : IDisposable
    {
        IEnumerable<Opskrift> GetOpskrifter();
        Opskrift GetOpskriftByID(int opskriftId);
        void InsertOpskrift(Opskrift opskrift);
        void DeleteOpskrift(int opskriftID);
        void UpdateOpskrift(Opskrift opskrift);
        void Save();
    }
}

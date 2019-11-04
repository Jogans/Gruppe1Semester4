using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tilbud.DAL
{
    public interface IStoresRepository : IDisposable
    {
        IEnumerable<Stores> GetStores();
        Stores GetStoresByID(int storesId);
        void InsertStores(Stores stores);
        void DeleteStores(int storesID);
        void UpdateStores(Stores stores);
        void Save();
    }
}

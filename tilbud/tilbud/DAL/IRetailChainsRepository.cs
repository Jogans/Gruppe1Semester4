using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tilbud.DAL
{
    interface IRetailChainsRepository : IDisposable
    {
        IEnumerable<RetailChains> GetRetailChains();
        RetailChains GetRetailChainsByID(int retailChainsId);
        void InsertRetailChains(RetailChains retailChains);
        void DeleteRetailChains(int retailChainsID);
        void UpdateRetailChains(RetailChains retailChains);
        void Save();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tilbud.DAL
{
    public interface IPrefsChainsRepository : IDisposable
    {
        IEnumerable<PrefsChains> GetPrefsChains();
        PrefsChains GetPrefsChainsByID(int prefsChainsId);
        void InsertPrefsChains(PrefsChains prefsChains);
        void DeletePrefsChains(int prefsChainsID);
        void UpdatePrefsChains(PrefsChains prefsChains);
        void Save();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tilbud.DAL
{
    public interface IAbningstidRepository : IDisposable
    {
        IEnumerable<Abningstid> GetAbningstider();
        Abningstid GetAbningstidByID(int abningstidId);
        void InsertAbningstid(Abningstid prefsCategories);
        void DeleteAbningstid(int prefsCategoriesID);
        void UpdateAbningstid(Abningstid prefsCategories);
        void Save();
    }
}

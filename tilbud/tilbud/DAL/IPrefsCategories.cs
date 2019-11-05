using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tilbud.DAL
{
    public interface IPrefsCategoriesRepository : IDisposable
    {
        IEnumerable<PrefsCategories> GetPrefsCategories();
        PrefsCategories GetPrefsCategoriesByID(int prefsCategoriesId);
        void InsertPrefsCategories(PrefsCategories prefsCategories);
        void DeletePrefsCategories(int prefsCategoriesID);
        void UpdatePrefsCategories(PrefsCategories prefsCategories);
        void Save();
    }
}

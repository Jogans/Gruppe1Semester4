using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using tilbud.DAL;

namespace tilbud.Repositories
{
    public class PrefsCategoriesRepository : IPrefsCategoriesRepository, IDisposable 
    {
        private prj4databaseContext context;

        public PrefsCategoriesRepository(prj4databaseContext context)
        {
            this.context = context;
        }

        public IEnumerable<PrefsCategories> GetPrefsCategories()
        {
            return context.PrefsCategories.ToList();
        }

        public PrefsCategories GetPrefsCategoriesByID(int id)
        {
            return context.PrefsCategories.Find(id);
        }

        public void InsertPrefsCategories(PrefsCategories prefsCategories)
        {
            context.PrefsCategories.Add(prefsCategories);
        }

        public void DeletePrefsCategories(int prefsCategoriesID)
        {
            PrefsCategories prefsCategories = context.PrefsCategories.Find(prefsCategoriesID);
            context.PrefsCategories.Remove(prefsCategories);
        }

        public void UpdatePrefsCategories(PrefsCategories prefsCategories)
        {
            context.Entry(prefsCategories).State = EntityState.Modified;
        }

        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}

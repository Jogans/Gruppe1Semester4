using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using tilbud;

namespace Transfer.Models
{
    public class IngredientListRepository : IIngredientListRepository, IDisposable
    {
        private prj4databaseContext context;

        public IngredientListRepository(prj4databaseContext context)
        {
            this.context = context;
        }

        public IEnumerable<IngredientList> GetIngredientLists()
        {
            return context.IngredientList.ToList();
        }

        public IngredientList GetIngredientListByID(int id)
        {
            return context.IngredientList.Find(id);
        }

        public void InsertIngredientList(IngredientList ingredientList)
        {
            context.IngredientList.Add(ingredientList);
        }

        public void DeleteIngredientList(int ingredientListID)
        {
            IngredientList ingredientList = context.IngredientList.Find(ingredientListID);
            context.IngredientList.Remove(ingredientList);
        }

        public void UpdateIngredientList(IngredientList ingredientList)
        {
            context.Entry(ingredientList).State = EntityState.Modified;
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

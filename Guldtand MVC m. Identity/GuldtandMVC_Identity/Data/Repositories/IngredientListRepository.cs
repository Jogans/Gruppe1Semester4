using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GuldtandMVC_Identity.Data.Queries;
using Microsoft.EntityFrameworkCore;


namespace GuldtandMVC_Identity.Data.Repositories
{
    public class IngredientListRepository : IDisposable
    {
        private prj4databaseContext context;

        public IngredientListRepository(prj4databaseContext context)
        {
            this.context = context;
        }

        public async Task<IEnumerable<IngredientList>> GetIngredientLists(IQuery<IngredientList> query)
        {
            return await query.Execute(context);
        }

        public void InsertIngredientList(IngredientList ingredientList)
        {
            context.IngredientList.Add(ingredientList);
        }

        public void DeleteIngredientList(int ingredientListId)
        {
            IngredientList ingredientList = context.IngredientList.Find(ingredientListId);
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

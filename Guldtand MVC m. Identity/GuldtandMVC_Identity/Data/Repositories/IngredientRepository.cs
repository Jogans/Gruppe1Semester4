using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GuldtandMVC_Identity.Data.Queries;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace GuldtandMVC_Identity.Data.Repositories
{
    public class IngredientRepository : IDisposable
    {
        private prj4databaseContext context;

        public IngredientRepository(prj4databaseContext context)
        {
            this.context = context;
        }

        public async Task<IEnumerable<Ingredient>> GetIngredients(IQuery<Ingredient> query)
        {
            return await query.Execute(context);
        }


        public void InsertIngredient(Ingredient ingredient)
        {
            context.Ingredient.Add(ingredient);
        }

        public void DeleteIngredient(int ingredientId)
        {
            Ingredient ingredient = context.Ingredient.Find(ingredientId);
            context.Ingredient.Remove(ingredient);
        }

        public void UpdateIngredient(Ingredient ingredient)
        {
            context.Entry(ingredient).State = EntityState.Modified;
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GuldtandMVC_Identity.Data.Queries;
using Microsoft.EntityFrameworkCore;


namespace GuldtandMVC_Identity.Data.Repositories
{
    public class DirectionsRepository : IDisposable
    {
        private prj4databaseContext context;

        public DirectionsRepository(prj4databaseContext context)
        {
            this.context = context;
        }

        public async Task<IEnumerable<Directions>> GetDirections(IQuery<Directions> query)
        {
            return await query.Execute(context);
        }

        public void InsertDirections(Directions directions)
        {
            context.Directions.Add(directions);
        }

        public void DeleteDirections(int directionsId)
        {
            Directions directions = context.Directions.Find(directionsId);
            context.Directions.Remove(directions);
        }

        public void UpdateDirections(Directions directions)
        {
            context.Entry(directions).State = EntityState.Modified;
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

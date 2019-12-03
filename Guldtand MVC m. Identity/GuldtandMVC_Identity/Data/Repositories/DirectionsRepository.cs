using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using GuldtandMVC_Identity.Data.Queries;
using Microsoft.EntityFrameworkCore;


namespace GuldtandMVC_Identity.Data.Repositories
{
    public class DirectionsRepository : IRepository<Directions>, IDisposable
    {
        private readonly prj4databaseContext _context;

        public DirectionsRepository(prj4databaseContext context)
        {
            this._context = context;
        }

        public async Task<IEnumerable<Directions>> Get(IQuery<Directions> query)
        {
            return await query.Execute(_context);
        }

        public void Insert(Directions directions)
        {
            _context.Directions.Add(directions);
        }

        public void Delete(int directionsId)
        {
            Directions directions = _context.Directions.Find(directionsId);
            _context.Directions.Remove(directions);
        }

        public void Update(Directions directions)
        {
            _context.Entry(directions).State = EntityState.Modified;
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        private bool _disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!this._disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this._disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}

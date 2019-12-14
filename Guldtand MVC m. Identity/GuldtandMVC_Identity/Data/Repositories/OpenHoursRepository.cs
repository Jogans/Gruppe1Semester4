using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using GuldtandMVC_Identity.Data.Queries;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace GuldtandMVC_Identity.Data.Repositories
{
    public class OpenHoursRepository : IRepository<OpenHours>, IDisposable
    {
        private readonly Prj4databaseContext _context;

        public OpenHoursRepository(Prj4databaseContext context)
        {
            this._context = context;
        }

        public async Task<IEnumerable<OpenHours>> Get(IQuery<OpenHours> query)
        {
            return await query.Execute(_context);
        }


        public void Insert(OpenHours openHours)
        {
            _context.OpenHours.Add(openHours);
        }

        public void Delete(int openHoursId)
        {
            OpenHours openHours = _context.OpenHours.Find(openHoursId);
            _context.OpenHours.Remove(openHours);
        }

        public void Update(OpenHours openHours)
        {
            _context.Entry(openHours).State = EntityState.Modified;
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

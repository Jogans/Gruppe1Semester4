using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GuldtandMVC_Identity.Data.Queries;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace GuldtandMVC_Identity.Data.Repositories
{
    public class OpenHoursRepository : IDisposable
    {
        private prj4databaseContext context;

        public OpenHoursRepository(prj4databaseContext context)
        {
            this.context = context;
        }

        public async Task<IEnumerable<OpenHours>> GetOpenHours(IQuery<OpenHours> query)
        {
            return await query.Execute(context);
        }


        public void InsertOpenHours(OpenHours openHours)
        {
            context.OpenHours.Add(openHours);
        }

        public void DeleteOpenHours(int openHoursId)
        {
            OpenHours openHours = context.OpenHours.Find(openHoursId);
            context.OpenHours.Remove(openHours);
        }

        public void UpdateOpenHours(OpenHours openHours)
        {
            context.Entry(openHours).State = EntityState.Modified;
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

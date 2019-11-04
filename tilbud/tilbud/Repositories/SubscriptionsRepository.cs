using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using tilbud.DAL;

namespace tilbud.Repositories
{
    public class SubscriptionsRepository : ISubscriptionsRepository, IDisposable
    {
        private prj4databaseContext context;

        public SubscriptionsRepository(prj4databaseContext context)
        {
            this.context = context;
        }

        public IEnumerable<Subscriptions> GetSubscriptions()
        {
            return context.Subscriptions.ToList();
        }

        public Subscriptions GetSubscriptionsByID(int id)
        {
            return context.Subscriptions.Find(id);
        }

        public void InsertSubscriptions(Subscriptions subscriptions)
        {
            context.Subscriptions.Add(subscriptions);
        }

        public void DeleteSubscriptions(int subscriptionsID)
        {
            Subscriptions subscriptions = context.Subscriptions.Find(subscriptionsID);
            context.Subscriptions.Remove(subscriptions);
        }

        public void UpdateSubscriptions(Subscriptions subscriptions)
        {
            context.Entry(subscriptions).State = EntityState.Modified;
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

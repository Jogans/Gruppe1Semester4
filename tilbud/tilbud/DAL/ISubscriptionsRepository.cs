using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tilbud.DAL
{
    public interface ISubscriptionsRepository : IDisposable
    {
        IEnumerable<Subscriptions> GetSubscriptions();
        Subscriptions GetSubscriptionsByID(int subscriptionsId);
        void InsertSubscriptions(Subscriptions subscriptions);
        void DeleteSubscriptions(int subscriptionsID);
        void UpdateSubscriptions(Subscriptions subscriptions);
        void Save();
    }
}

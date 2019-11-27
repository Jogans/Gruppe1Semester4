using System.Collections.Generic;
using System.Threading.Tasks;
using GuldtandMVC_Identity.Data.Queries;


namespace GuldtandMVC_Identity.Data.Repositories
{
    interface IRepository<T>
    {
        Task<IEnumerable<T>> Get(IQuery<T> query);
        void Insert(T entity);
        void Delete(int id);
        void Update(T entity);
        void Save();
        void Dispose();
    }
}

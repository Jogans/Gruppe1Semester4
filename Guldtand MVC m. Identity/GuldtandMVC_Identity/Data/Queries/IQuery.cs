using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GuldtandMVC_Identity.Data.Queries
{
    public interface IQuery<T>
    {
         Task<IEnumerable<T>> Execute(Prj4databaseContext context);
    }
}

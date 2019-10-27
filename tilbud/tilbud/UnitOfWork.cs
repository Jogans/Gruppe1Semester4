using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tilbud
{
    public class UnitOfWork : IDisposable
    {
        private prj4databaseContext context = new prj4databaseContext();
        //private Repository<Vare> vareRepository;

        public void Save() { context.SaveChanges(); }
        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}

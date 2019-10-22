using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tilbud
{
    public class AppDb : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer("Data Source=prj4-server.database.windows.net;Initial Catalog=[prj4-database];User ID=martin;Password=sY0$*68y!N0v");
            optionsBuilder.UseSqlServer("Provider=SQLOLEDB.1;Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=projtest;Data Source=DESKTOP-0FHV6SU\\MSSQLSERVER2");
        }
    }
}

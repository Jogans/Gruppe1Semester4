using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DbContext = System.Data.Entity.DbContext;

namespace AspNetCore
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        { }

        public System.Data.Entity.DbSet<guldtand> Guldtandhjemmesides { get; set; }

        internal Task AddAsync(guldtand model)
        {
            throw new NotImplementedException();
        }
    }
}
    


using Microsoft.EntityFrameworkCore;

namespace Registry_API.Data
{
    public class APIDB : DbContext
    {

        public APIDB(DbContextOptions<APIDB> options) :base (options)
            { 
        }

        public DbSet<Talent> Talents { get; set; }

    }
}

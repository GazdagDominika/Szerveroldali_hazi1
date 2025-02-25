using Microsoft.EntityFrameworkCore;
using Szerveroldali_hazi1.Entities;

namespace Szerveroldali_hazi1.Data
{
    public class Duna_VizallasContext: DbContext
    {
        public DbSet<Duna_Vizallas> Vizallas { get; set;}

        public Duna_VizallasContext(DbContextOptions<Duna_VizallasContext> opt):base(opt)
        {
            Database.EnsureCreated();
        }

        
    }
}

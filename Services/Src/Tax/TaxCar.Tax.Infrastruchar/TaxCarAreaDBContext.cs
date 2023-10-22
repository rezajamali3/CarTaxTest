
using Microsoft.EntityFrameworkCore;
using CarTax.Tax.Domain;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarTax.City.Infrastruchar.Configurtions.Maping;

namespace TaxCar.Tax.Infrastruchar
{
    public class TaxCarAreaDBContext : DbContext
    {

        public TaxCarAreaDBContext() { }

        public TaxCarAreaDBContext(DbContextOptions<TaxCarAreaDBContext> options) : base(options) { }

      

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfiguration(new TaxCarAreaFlunt());


            base.OnModelCreating(modelBuilder);

        }

        public bool AreMigrationsPending()
        {
            var pendingMigrations = Database.GetPendingMigrations();
            return pendingMigrations.Any();
        }

        public bool HasMigrationsApplied()
        {
            var appliedMigrations = Database.GetAppliedMigrations();
            return appliedMigrations.Any();
        }

        public DbSet<TaxCarArea> TaxCarAreas { get; set; }
       

    }
}


using CarTax.Combinedstation.Infrastruchar.Configurtions.Maping;
using Microsoft.EntityFrameworkCore;
using TaxCar.Combinedstation.Core;

namespace TaxCar.Combinedstation.Infrastruchar
{
    public class CombinedstationDBContext : DbContext
    {

        public CombinedstationDBContext() { }

        public CombinedstationDBContext(DbContextOptions<CombinedstationDBContext> options) : base(options) { }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CombinedStationFlunt());
          
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


        public DbSet<CombinedStations> CombinedStations { get; set; }

       

    }
}
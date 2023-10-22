


using Microsoft.EntityFrameworkCore;
using TaxCar.Publicholidays.Infrastruchar.Configurtions.Maping;

namespace TaxCar.Publicholidays.Infrastruchar
{
    public class PublicholidayDBContext : DbContext
    {

        public PublicholidayDBContext(){}

        public PublicholidayDBContext(DbContextOptions<PublicholidayDBContext> options) : base(options){}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PublicholidayFlunt());
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

        public DbSet<Publicholiday> Publicholidays { get; set; }


    }
}

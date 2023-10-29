using CarTax.Car.Domain;
using CarTax.Car.Infrastruchar.Configurtions.Maping;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarTax.Car.Infrastruchar
{
    public class CarDBContext : DbContext
    {

        public CarDBContext(){}

        public CarDBContext(DbContextOptions<CarDBContext> options) : base(options){}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CarFlunt());
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

    
        public DbSet<Cars> Cars { get; set; }

    }
}

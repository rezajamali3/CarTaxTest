
using CarTax.CarType.Domain;
using CarTax.CarType.Infrastruchar.Configurtions.Maping;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxCar.CarType.Infrastruchar
{
    public class CarTypeDBContext : DbContext
    {

        public CarTypeDBContext() { }

        public CarTypeDBContext(DbContextOptions<CarTypeDBContext> options) : base(options) { }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfiguration(new CarTypeFlunt());

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

        public DbSet<CarTypes> CarTypes { get; set; }
       

    }
}


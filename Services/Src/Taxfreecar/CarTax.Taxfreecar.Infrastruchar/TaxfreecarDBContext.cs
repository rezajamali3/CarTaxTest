



using CarTax.AggregateRoot;
using CarTax.Taxfreecar.Infrastruchar.Configurtions.Maping;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarTax.Taxfreecar.Infrastruchar
{
    public class TaxfreecarDBContext : DbContext
    {

        public TaxfreecarDBContext() { }

        public TaxfreecarDBContext(DbContextOptions<TaxfreecarDBContext> options) : base(options) { }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfiguration(new TaxfreecarFlunt());

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

        public DbSet<TaxFreeCar> Taxfreecar { get; set; }
       

    }
}


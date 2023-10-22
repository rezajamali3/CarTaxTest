

using CarTax.Area.Domain;
using CarTax.Area.Domain.Entity;
using CarTax.Area.Infrastruchar.Configurtions.Maping;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarTax.Area.Infrastruchar
{
    public class AreasDBContext : DbContext
    {

        public AreasDBContext(){}

        public AreasDBContext(DbContextOptions<AreasDBContext> options) : base(options){}


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AreaFlunt());
            modelBuilder.ApplyConfiguration(new SpecifichourlytaxFlunt());
          
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

    
        public DbSet<Areas> Areas { get; set; }

        public DbSet<Specifichourlytax> Specifichourlytax { get; set; }

        public DbSet<Taxfreecar> Taxfreecars { get; set; }

    }
}

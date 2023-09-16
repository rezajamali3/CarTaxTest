

using Cartax.Domain.Entites.Areas;
using Cartax.Domain.Entites.Cars;
using Cartax.Domain.Entites.Citys;
using Cartax.Domain.Entites.Tax.TaxCars;
using Cartax.Domain.Entites.Tax.TaxLimitDays;
using Cartax.Domain.Entites.Tax.TaxLimitTimes;
using Cartax.Domain.Entites.Tax.TaxLongTerms;
using Cartax.Domain.Entites.Tax.TaxPublicholidays;
using Cartax.Domain.Entites.Tax.TaxTimes;
using Cartax.Domain.Entites.Tax.TaxWeekDays;
using Cartax.Presentation.Data.EntitiesConfig;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cartax.Presentation
{
    public class CarTaxContext : DbContext
    {

        public CarTaxContext(DbContextOptions<CarTaxContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            #region City
            modelBuilder.ApplyConfiguration(new CityDataConfiguertions());
            modelBuilder.ApplyConfiguration(new AreaDataConfiguertions());
            #endregion City

            #region Car
            modelBuilder.ApplyConfiguration(new CarDataConfiguertions());
            modelBuilder.ApplyConfiguration(new CarTypeDataConfiguertions());
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(CarTaxContext).Assembly);
            #endregion Car

            #region Tax
            modelBuilder.ApplyConfiguration(new TaxCarDataConfigurtion());
            modelBuilder.ApplyConfiguration(new TaxLimitTimeDataConfigurtion());
            modelBuilder.ApplyConfiguration(new TaxPublicholidayDataConfigurtions());
            modelBuilder.ApplyConfiguration(new TaxTaxLongTermDataConfiguertion());
            modelBuilder.ApplyConfiguration(new TaxTimeDataConfiguertions());
            modelBuilder.ApplyConfiguration(new TaxWeekDayDataConfigurtions());
            #endregion tax

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


        public DbSet<Area> Area                          { get; set; }
        public DbSet<Car> Car                            { get; set; }
        public DbSet<City> City                          { get; set; }
        public DbSet<TaxCar>        TaxCar               { get; set; }
        public DbSet<TaxWeekDay>      TaxWeekDay         { get; set; }
        public DbSet<TaxLimitDay>      TaxLimitDay       { get; set; }
        public DbSet<TaxLimitTime>    TaxLimitTime       { get; set; }
        public DbSet<TaxTaxLongTerm> TaxTaxLongTerm      { get; set; }
        public DbSet<TaxPublicholiday> TaxPublicholiday  { get; set; }
        public DbSet<TaxTime> TaxTime                    { get; set; }
        public DbSet<TaxPublicholiday> taxPublicholidays { get; set; }
        
    }
}

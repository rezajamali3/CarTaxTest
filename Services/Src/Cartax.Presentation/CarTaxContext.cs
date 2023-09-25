using Cartax.Applications.Common.Intercpter;
using Cartax.Domain.Domain.Citys.Entitys;
using Cartax.Domain.Entites.Cars;
using Cartax.Domain.Entites.Tax.TaxCars;
using Cartax.Presentation.Data.EntitiesConfig;
using Cartax.Presentation.Migrations.FluentConfigure;
using MediatR;
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
        private readonly IMediator _mediator;
        private readonly PublishDomainEventIntercpter _interceptor;

        public CarTaxContext(DbContextOptions<CarTaxContext> options, IMediator mediator) : base(options)
        {
            _mediator = mediator;
            _interceptor = new PublishDomainEventIntercpter(mediator);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            #region You are the table 
            modelBuilder
            .CarTypeFluntConfigure()
            .CarFluntConfigure()
            .CityFluntConfigure()
            .AreaFluntConfigure()
            .TaxCarFluntConfigure()
            .TaxLimitMoneyDaysFluntConfigure()
            .TaxLimitTimeFluntConfigure()
            .TaxPublicholidayFluntConfigure()
            .TaxTaxLongTermFluntConfigure()
            .TaxTimeFluntConfigure()
            .TaxWeekDayFluntConfigure();

            #endregion You are the table

            #region Defult Data
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
            modelBuilder.ApplyConfiguration(new TaxLimitDayDateConfigurtions());

            #endregion tax
            #endregion Defult Data


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

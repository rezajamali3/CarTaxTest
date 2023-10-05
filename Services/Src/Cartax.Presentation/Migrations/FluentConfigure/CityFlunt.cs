
using Cartax.Domain.Domain.Citys.Entitys;
using MathNet.Numerics.Distributions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using NPOI.SS.Formula.Functions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Cartax.Presentation.Migrations.FluentConfigure
{
    public static class CityFlunt
    {
        public static ModelBuilder CityFluntConfigure(this ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<City>( x =>
            {
                x.Property<int?>(p => p.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions
                .UseIdentityColumn(x.Property<int?>(p => p.Id));

                x.Property<string>(p => p.CityCode)
                    .HasColumnType("nvarchar(max)");

                x.Property<string>(p => p.CityName)
                    .HasColumnType("nvarchar(max)");

                x.HasMany(c => c.Areas)
                 .WithOne(a => a.City)
                 .HasForeignKey("CityId");

             


                x.HasMany(c => c.TaxPublicholiday)
              .WithOne(a => a.City)
              .HasForeignKey("CityId");


            x.HasMany(c => c.TaxTaxLongTerm)
             .WithOne(a => a.City)
             .HasForeignKey("CityId");

             x.HasMany(c => c.TaxWeekDay)
              .WithOne(a => a.City)
              .HasForeignKey("CityId");


             x.HasOne(c => c.TaxMoneyDay)
              .WithOne(a => a.City)
              .HasForeignKey<TaxLimitMoneyDay>(a=>a.Id)
              .IsRequired(false);


             x.HasOne(c => c.TaxLimitTime)
              .WithOne(a => a.City)
              .HasForeignKey<TaxLimitTime>(a => a.Id)
              .IsRequired(false);




                x.HasKey(p => p.Id);

                x.ToTable("City");

              
            });


            return modelBuilder;
        }
    }
}

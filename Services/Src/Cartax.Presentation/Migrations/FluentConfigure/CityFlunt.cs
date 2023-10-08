
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
        //public static ModelBuilder CityFluntConfigure(this ModelBuilder modelBuilder)
        //{

<<<<<<< HEAD
        //    modelBuilder.Entity(typeof(City), b =>
        //    {
        //        b.Property<int?>("Id")
        //            .ValueGeneratedOnAdd()
        //            .HasColumnType("int");

        //        SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"));

        //        b.Property<string>("CityCode")
        //            .HasColumnType("nvarchar(max)");

        //        b.Property<string>("CityName")
        //            .HasColumnType("nvarchar(max)");

        //        b.HasKey("Id");

        //        b.ToTable("City");

        //        b.HasData(
        //            new
        //            {
        //                Id = 1,
        //                CityCode = "FitNet10",
        //                CityName = "Gothenburg"
        //            },
        //            new
        //            {
        //                Id = 2,
        //                CityCode = "FitNet45",
        //                CityName = "Eroica"
        //            },
        //            new
        //            {
        //                Id = 3,
        //                CityCode = "FitNet48",
        //                CityName = "Avesta"
        //            });
        //    });



        //    modelBuilder.Entity<City>()
        //   .HasMany(c => c.Areas)
        //   .WithOne(a => a.City)
        //   .HasForeignKey(a => a.idCity);


        //    modelBuilder.Entity<City>()
        // .HasMany(c => c.CarTypes)
        // .WithOne(a => a.City)
        // .HasForeignKey(a => a.Idcity);

        //    return modelBuilder;
        //}
=======
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
>>>>>>> 6e0109040902ca67597d3488cf835a7f8636c8fb
    }
}

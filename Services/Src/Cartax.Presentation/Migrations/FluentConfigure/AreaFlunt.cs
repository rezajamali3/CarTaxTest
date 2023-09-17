using Cartax.Domain.Entites.Areas;
using Cartax.Domain.Entites.Citys;
using Cartax.Domain.Entites.Tax.TaxLimitDays;
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
    public static class AreaFlunt
    {
         
        public static ModelBuilder AreaFluntConfigure(this ModelBuilder modelBuilder)
        {

            modelBuilder.Entity(typeof(Area), b =>
            {
                b.Property<int?>("Id")
                    .ValueGeneratedNever()
                    .IsRequired()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"));

                b.Property<string>("AreaCode")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("AreaName")
                    .HasColumnType("nvarchar(max)");

                b.HasKey("Id");

                b.ToTable("Area");

              
          


            });

            modelBuilder.Entity<Area>()
           .HasOne(a => a.City)
           .WithMany(b=>b.Areas)
           .HasForeignKey(a => a.idCity);


            modelBuilder.Entity<Area>()
         .HasMany(a => a.TaxCars)
         .WithOne(b => b.Area)
         .HasForeignKey(a => a.Idarea);

          //  modelBuilder.Entity<Area>()
          //.HasOne(a => a.TaxLimitDay)
          //.WithMany()
          //.HasPrincipalKey(sc => sc.IdArea)
          //.OnDelete(DeleteBehavior.SetNull);

          //  modelBuilder.Entity<Area>()
          //.HasOne(a => a.TaxWeekDay)
          //.WithMany()
          //.HasPrincipalKey(sc => sc.IdArea)
          //.OnDelete(DeleteBehavior.SetNull);

            return modelBuilder;
        }

    }
}

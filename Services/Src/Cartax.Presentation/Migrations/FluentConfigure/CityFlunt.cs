
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
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(x.Property<int?>(p => p.Id));

                x.Property<string>(p => p.CityCode)
                    .HasColumnType("nvarchar(max)");

                x.Property<string>(p => p.CityName)
                    .HasColumnType("nvarchar(max)");

                x.HasKey(p => p.Id);

                x.ToTable("City");

              
            });



            modelBuilder.Entity<City>()
           .HasMany(c => c.Areas)
           .WithOne(a => a.City)
           .HasForeignKey(a => a.idCity);


            modelBuilder.Entity<City>()
         .HasMany(c => c.CarTypes)
         .WithOne(a => a.City)
         .HasForeignKey(a => a.Idcity);

            return modelBuilder;
        }
    }
}

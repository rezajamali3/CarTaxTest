using Cartax.Domain.Entites.CarTypes;
using Cartax.Domain.Entites.Citys;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cartax.Presentation.Migrations.FluentConfigure
{
    public static class CarTypeFlunt
    {
        public static ModelBuilder CarTypeFluntConfigure(this ModelBuilder modelBuilder)
        {

            modelBuilder.Entity(typeof(CarType), b =>
            {
                b.Property<int?>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"));

                b.Property<string>("CarName")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<int>("Idcity")
                    .HasColumnType("int");

                b.Property<bool?>("IsActive")
                    .HasColumnType("bit");

                b.Property<bool?>("IsTaxActive")
                    .HasColumnType("bit");

                b.HasKey("Id");

                b.ToTable("CarType");

                //b.HasData(
                //    new
                //    {
                //        Id = 1,
                //        CarName = "Normal",
                //        Idcity = 1,
                //        IsActive = true,
                //        IsTaxActive = true
                //    },
                //    new
                //    {
                //        Id = 2,
                //        CarName = "Emergency",
                //        Idcity = 1,
                //        IsActive = true,
                //        IsTaxActive = false
                //    },
                //    new
                //    {
                //        Id = 3,
                //        CarName = "Busses",
                //        Idcity = 1,
                //        IsActive = true,
                //        IsTaxActive = false
                //    },
                //    new
                //    {
                //        Id = 4,
                //        CarName = "Diplomat",
                //        Idcity = 1,
                //        IsActive = true,
                //        IsTaxActive = false
                //    },
                //    new
                //    {
                //        Id = 5,
                //        CarName = "Motorcycles",
                //        Idcity = 1,
                //        IsActive = true,
                //        IsTaxActive = false
                //    },
                //    new
                //    {
                //        Id = 6,
                //        CarName = "Military",
                //        Idcity = 1,
                //        IsActive = true,
                //        IsTaxActive = false
                //    },
                //    new
                //    {
                //        Id = 7,
                //        CarName = "Foreign",
                //        Idcity = 1,
                //        IsActive = true,
                //        IsTaxActive = false
                //    });
            });


            modelBuilder.Entity<CarType>()
           .HasMany(c => c.Cars)
           .WithOne(a => a.CarType)
           .HasForeignKey(a => a.IdCarType);

            modelBuilder.Entity<CarType>()
          .HasOne(c => c.City)
          .WithMany(a => a.CarTypes)
          .HasForeignKey(a => a.Idcity);

            return modelBuilder;
        }
    }
}


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
        //public static ModelBuilder CarTypeFluntConfigure(this ModelBuilder modelBuilder)
        //{

        //    modelBuilder.Entity(typeof(CarType), b =>
        //    {
        //        b.Property<int?>("Id")
        //            .ValueGeneratedOnAdd()
        //            .HasColumnType("int");

        //        SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"));

        //        b.Property<string>("CarName")
        //            .IsRequired()
        //            .HasColumnType("nvarchar(max)");

        //        b.Property<int>("Idcity")
        //            .HasColumnType("int");

        //        b.Property<bool?>("IsActive")
        //            .HasColumnType("bit");

        //        b.Property<bool?>("IsTaxActive")
        //            .HasColumnType("bit");

        //        b.HasKey("Id");

        //        b.ToTable("CarType");

              
        //    });


        //    modelBuilder.Entity<CarType>()
        //   .HasMany(c => c.Cars)
        //   .WithOne(a => a.CarType)
        //   .HasForeignKey(a => a.IdCarType);

        //    modelBuilder.Entity<CarType>()
        //  .HasOne(c => c.City)
        //  .WithMany(a => a.CarTypes)
        //  .HasForeignKey(a => a.Idcity);

        //    return modelBuilder;
        //}
    }
}

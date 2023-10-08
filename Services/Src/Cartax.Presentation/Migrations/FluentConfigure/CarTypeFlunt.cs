
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

<<<<<<< HEAD
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
=======
            modelBuilder.Entity<CarType>(x =>
            {
                x.Property<int?>(p => p.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(x.Property<int?>(p => p.Id));

                x.Property<string>(p => p.CarName)
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                x.Property<bool?>(p => p.IsActive)
                 .HasColumnType("bit");

                x.Property<bool?>(p => p.IsTaxActive)
                 .HasColumnType("bit");


                //x.HasMany(c => c.Cars)
                // .WithOne(a => a.CarType)
                // .HasForeignKey("CarTypeId");

             

                x.HasKey(p => p.Id);

                x.ToTable("CarType");


            });



>>>>>>> 6e0109040902ca67597d3488cf835a7f8636c8fb

        //    return modelBuilder;
        //}
    }
}



using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cartax.Presentation.Migrations.FluentConfigure
{
    public static class CarFlunte 
    {
      //  public static ModelBuilder CarFluntConfigure(this ModelBuilder modelBuilder)
      //  {

<<<<<<< HEAD
      //      modelBuilder.Entity(typeof(Car) , b =>
      //      {
      //          b.Property<int?>("Id")
      //              .ValueGeneratedOnAdd()
      //              .HasColumnType("int");

      //          SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"));

      //          b.Property<string>("CarName")
      //              .IsRequired()
      //              .HasColumnType("nvarchar(50)");

      //          b.Property<int?>("IdCarType")
      //          .IsRequired()
      //              .HasColumnType("int");

      //          b.HasKey("Id");

      //          b.ToTable("Car");

             
=======
            modelBuilder.Entity<Car>(x =>
            {
                x.Property<int?>(p => p.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(x.Property<int?>("Id"));

                x.Property<string>(p => p.CarName)
                 .IsRequired()
                 .HasColumnType("nvarchar(50)");


               x .HasOne(a => a.CarType)
                 .WithMany(b => b.Cars)
                 .HasForeignKey("CarTypeId");

>>>>>>> 6e0109040902ca67597d3488cf835a7f8636c8fb

              
                 x.HasMany(a => a.TaxCars)
                 .WithOne(b => b.Car)
                 .HasForeignKey("CarId");



                x.HasKey(p => p.Id);

                x.ToTable("Car");





      //      });


<<<<<<< HEAD
      //      modelBuilder.Entity<Car>()
      //   .HasOne(a => a.CarType)
      //   .WithMany(b=>b.Cars)
      //   .HasForeignKey(a => a.IdCarType);


      //      modelBuilder.Entity<Car>()
      //.HasMany(a => a.TaxCars)
      //.WithOne(b => b.Car)
      //.HasForeignKey(a => a.Idcar);
=======
         
>>>>>>> 6e0109040902ca67597d3488cf835a7f8636c8fb

      //      return modelBuilder;
      //  }
    }
}

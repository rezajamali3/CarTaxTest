using Cartax.Domain.Entites.Areas;
using Cartax.Domain.Entites.Cars;
using Cartax.Domain.Entites.CarTypes;
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
        public static ModelBuilder CarFluntConfigure(this ModelBuilder modelBuilder)
        {

            modelBuilder.Entity(typeof(Car) , b =>
            {
                b.Property<int?>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"));

                b.Property<string>("CarName")
                    .IsRequired()
                    .HasColumnType("nvarchar(50)");

                b.Property<int?>("IdCarType")
                .IsRequired()
                    .HasColumnType("int");

                b.HasKey("Id");

                b.ToTable("Car");

             

              

            });


            modelBuilder.Entity<Car>()
         .HasOne(a => a.CarType)
         .WithMany(b=>b.Cars)
         .HasForeignKey(a => a.IdCarType);


            modelBuilder.Entity<Car>()
      .HasMany(a => a.TaxCars)
      .WithOne(b => b.Car)
      .HasForeignKey(a => a.Idcar);

            return modelBuilder;
        }
    }
}

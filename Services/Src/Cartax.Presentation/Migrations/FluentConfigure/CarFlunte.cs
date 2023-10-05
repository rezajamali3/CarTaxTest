
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


              
                 x.HasMany(a => a.TaxCars)
                 .WithOne(b => b.Car)
                 .HasForeignKey("CarId");



                x.HasKey(p => p.Id);

                x.ToTable("Car");





            });


         

            return modelBuilder;
        }
    }
}

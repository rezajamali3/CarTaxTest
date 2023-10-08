

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarTax.Car.Domain.Root;


namespace CarTax.Car.Infrastruchar.Configurtions.Maping
{
    public static class CarFlunte 
    {
        public static ModelBuilder CarFluntConfigure(this ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Cars>(x =>
            {
                x.Property<int?>(p=>p.Id).HasColumnName("CarId")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(x.Property<int?>(p => p.Id));

                x.Property<string>(p => p.CarName)
                    .IsRequired()
                    .HasColumnType("nvarchar(50)");

                x.Property<int?>(p => p.CarType.Id).HasColumnName("CarTypeId")
                 .IsRequired()
                 .HasColumnType("int");

                x.HasKey("Id");

                x.ToTable("Car");


            });


        

            return modelBuilder;
        }
    }
}

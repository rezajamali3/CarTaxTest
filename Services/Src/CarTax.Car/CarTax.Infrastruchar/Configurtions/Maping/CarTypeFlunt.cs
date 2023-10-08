
using CarTax.Car.Domain.Entitys;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarTax.Car.Infrastruchar.Configurtions.Maping
{
    public static class CarTypeFlunt 
    {
        public static ModelBuilder CarTypeFluntConfigure(this ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<CarType>( x =>
            {
                x.Property<int?>(p=>p.Id).HasColumnName("CarTypeId")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(x.Property<int?>(p => p.Id));

                x.Property<string>(p => p.NameTypeCar)
                    .IsRequired()
                    .HasColumnType("nvarchar(60)");

              
                x.Property<bool?>(p => p.IsActive)
                    .HasColumnType("bit");

               x.Property<bool?>(p => p.IsTaxActive)
                    .HasColumnType("bit");

               x
       .HasMany(c => c.Cars)
       .WithOne(a => a.CarType)
       .HasForeignKey();


                x.HasKey(p => p.Id);

                x.ToTable("CarType");


            });


         
         

            return modelBuilder;
        }
    }
}

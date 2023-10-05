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
    public static class CarTypeFlunt
    {
        public static ModelBuilder CarTypeFluntConfigure(this ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<CarType>( x =>
            {
                x.Property<int?>(p => p.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(x.Property<int?>(p => p.Id));

                x.Property<string>(p => p.CarName)
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                x.Property<int>(p => p.Idcity)
                    .HasColumnType("int");

                x.Property<bool?>(p => p.IsActive)
                    .HasColumnType("bit");

                x.Property<bool?>(p => p.IsTaxActive)
                    .HasColumnType("bit");

               x.HasKey(p => p.Id);

                x.ToTable("CarType");

              
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



using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NPOI.OpenXmlFormats.Dml.Diagram;
using CarTax.Car.Domain.ValueObjects;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;
using CarTax.Car.Domain;

namespace CarTax.Car.Infrastruchar.Configurtions.Maping
{
    public  class CarFlunt :IEntityTypeConfiguration<Cars>
    {


        public void Configure(EntityTypeBuilder<Cars> builder)
        {

            builder.HasKey(p => p.Id).HasName("CarId");

            builder.Property(p => p.Id)
                 .ValueGeneratedOnAdd()
                 .HasColumnType("int")
                 .IsRequired()
                 .HasConversion
                 (
                  CarId => CarId.Value,
                  Value => CarId.Create(Value)
                 );

            builder.Property(p => p.CarName)
                    .HasConversion(
                     CarName => CarName.Value,
                     Value => CarName.Create(Name.Create(Value)))
                    .IsRequired()
                    .HasColumnType("nvarchar(50)");


            builder.OwnsOne(
               o => o.Plack,
               numberBuilder =>
               {
                   numberBuilder.Property(n => n.CodePlack)
                   .HasColumnType("nvarchar(2)")
                   .HasColumnName("CodePlack");

                   numberBuilder.Property(n => n.NumberPlack)
                  .HasColumnType("nvarchar(20)")
                  .HasColumnName("NumberPlack");

               });

            builder.Property(p => p.IsActive)
                .HasColumnType("bit");

            builder.Ignore(o => o.State);



            builder.Property(c => c.CarTypeId)
                   .HasColumnType("tinyint");

            builder.Property(c => c.Version)
                 .HasColumnType("int");

            builder.ToTable("Cars");

        }
    }
}

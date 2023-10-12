
using CarTax.CarType.Domain;
using CarTax.CarType.Domain.ValueObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace CarTax.CarType.Infrastruchar.Configurtions.Maping
{
    public  class CarTypeFlunt : IEntityTypeConfiguration<CarTypes>
    {


        public void Configure(EntityTypeBuilder<CarTypes> builder)
        {
            builder.HasKey(p => p.Id).HasName("CarTypeId");

            builder.Property(p => p.Id)
                    .ValueGeneratedNever()
                    .HasConversion(
                     CartyprId => CartyprId.Value,
                     Value => CarTypeId.Create(Value))
                    .HasColumnType("tinyint")
                    .HasColumnName("CarTypeId");



            builder.Property(p => p.TypeCarName)
                .HasConversion(NameTypeCar => NameTypeCar.Value,
                               Value => TypeCarName.Create(Name.Create(Value)))
                 .IsRequired()
                 .HasColumnType("nvarchar(60)");

            builder.Property<bool?>(p => p.IsActive)
                 .HasColumnType("bit");

            builder.Property<bool?>(p => p.IsTaxActive)
                 .HasColumnType("bit");

          

            builder.ToTable("CarTypes");

        }
    }
}

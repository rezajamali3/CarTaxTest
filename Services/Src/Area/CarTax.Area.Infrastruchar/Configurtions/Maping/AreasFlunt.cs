

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NPOI.OpenXmlFormats.Dml.Diagram;
using CarTax.Area.Domain.ValueObjects;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;
using CarTax.Area.Domain;
using CarTax.Area.Domain.Entity;
using CarTax.Area.Domain.ValueObject;

namespace CarTax.Area.Infrastruchar.Configurtions.Maping
{
    public  class AreaFlunt : IEntityTypeConfiguration<Areas>
    {


        public void Configure(EntityTypeBuilder<Areas> builder)
        {

            builder.HasKey(p => p.Id).HasName("AreaId");

            builder.Property(p => p.Id)
                 .ValueGeneratedNever()
                 .HasColumnType("int")
                 .HasConversion(
                 AreaId => AreaId.Value,
                 Value => AreaId.Create(Value));


            builder.Property(p => p.Maximumdailytaxamount)
              .HasColumnType("decimal(18,02)")
              .HasConversion(
              MaximumdailytaxamountId => MaximumdailytaxamountId.Value,
              Value => Maximumdailytaxamount.Create(Value));

            builder.Property(p => p.limitedMinutes)
            .HasColumnType("int")
            .HasConversion(
            Limitedminutesofpassingfromtheconsolidatedstation => Limitedminutesofpassingfromtheconsolidatedstation.Value,
            Value => Limitedminutesofpassingfromtheconsolidatedstation.Create(Value));

            
            builder.Property(p => p.AreaName)
                    .HasConversion(
                     AreaName => AreaName.Value,
                     Value => AreaName.Create(Name.Create(Value)))
                    .IsRequired()
                    .HasColumnType("nvarchar(50)");

            builder.Property(p => p.AreaCode)
                   .HasConversion(
                    AreaCode => AreaCode.Value,
                    Value => AreaCode.Create(Value))
                   .IsRequired()
                   .HasColumnType("nvarchar(3)");


            builder.Property(p => p.IsActive)
                .HasColumnType("bit");

            builder.Property(c => c.CityId)
                   .HasColumnType("int");

            builder.Ignore(o => o.State);


            builder.HasMany(o=>o.Taxfreecar)
             .WithOne()
             .HasForeignKey("AreaId")
             .OnDelete(DeleteBehavior.NoAction);

            builder.HasMany(o => o.Specifichourlytaxes)
            .WithOne()
            .HasForeignKey("AreaId")
            .OnDelete(DeleteBehavior.NoAction);


            builder.ToTable("Area");

        }
    }
}

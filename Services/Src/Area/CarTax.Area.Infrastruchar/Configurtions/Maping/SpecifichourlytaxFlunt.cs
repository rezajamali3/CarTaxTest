
using CarTax.Area.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarTax.Area.Infrastruchar.Configurtions.Maping
{
    internal class SpecifichourlytaxFlunt : IEntityTypeConfiguration<Specifichourlytax>
    {


        public void Configure(EntityTypeBuilder<Specifichourlytax> builder)
        {

            builder.HasKey(p => p.Id).HasName("SpecifichourlytaxId");

            builder.Property(p => p.Id)
                 .ValueGeneratedNever()
                 .HasColumnType("int")
                 .HasConversion(
                 SpecifichourlytaxId => SpecifichourlytaxId.Value,
                 Value => SpecifichourlytaxId.Create(Value));

            builder.OwnsOne(
               o => o.Specifichourly,
               numberBuilder =>
               {
                   numberBuilder.Property(n => n.StartTimeSpan)
                   .HasColumnType("time")
                   .HasColumnName("StartTimeSpan");

                   numberBuilder.Property(n => n.EndTimeSpan)
                  .HasColumnType("time")
                  .HasColumnName("EndTimeSpan");

               });

            builder.Property(p => p.Tax)
                   .HasConversion(
                    SpecifichourlyTax => SpecifichourlyTax.Value,
                    Value => SpecifichourlyTax.Create(Value))
                   .IsRequired()
                   .HasColumnType("decimal(18,2)");

            builder.Ignore(o => o.State);
            builder.ToTable("Specifichourlytax");

        }
    }
}

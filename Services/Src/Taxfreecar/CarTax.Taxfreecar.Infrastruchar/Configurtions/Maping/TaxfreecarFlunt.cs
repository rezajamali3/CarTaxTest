
using CarTax.AggregateRoot;
using CarTax.Taxfreecar.Domain.ValueObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Security.Cryptography;



namespace CarTax.Taxfreecar.Infrastruchar.Configurtions.Maping
{
    public  class TaxfreecarFlunt : IEntityTypeConfiguration<TaxFreeCar>
    {


        public void Configure(EntityTypeBuilder<TaxFreeCar> builder)
        {


            builder.HasKey(p => p.Id).HasName("TaxfreecarId");


            builder.Property(p => p.Id)
                    .ValueGeneratedNever()
                    .HasConversion(
                     TaxfreecarId => TaxfreecarId.Value,
                     Value => TaxfreecarId.Create(Value))
                    .HasColumnType("int")
                    .HasColumnName("TaxfreecarId");


           


            builder.Property<int?>(p => p.AreaId)
                 .HasColumnType("int");
            builder.Property<int?>(p => p.TypeCarId)
                .HasColumnType("int");
            builder.Property<bool?>(p => p.IsActive)
                .HasColumnType("bit");

            builder.Ignore(o => o.State);
            builder.ToTable("Taxfreecar");

        }
    }
}



using CarTax.Area.Domain.Entity;
using CarTax.Area.Domain.ValueObject;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;




namespace CarTax.Area.Infrastruchar.Configurtions.Maping
{
    public  class TaxfreecarFlunt : IEntityTypeConfiguration<Taxfreecar>
    {


        public void Configure(EntityTypeBuilder<Taxfreecar> builder)
        {


            builder.HasKey(p => p.Id)
                .HasName("TaxfreecarId");


            builder.Property(p => p.Id)
                    .ValueGeneratedNever()
                    .HasConversion(
                     TaxfreecarId => TaxfreecarId.Value,
                     Value => TaxfreecarId.Create(Value))
                    .HasColumnType("int")
                    .HasColumnName("TaxfreecarId");

            builder.Property<int?>(p => p.TypeCarId)
                .HasColumnType("int");

            builder.Property<bool?>(p => p.IsActive)
                .HasColumnType("bit");

            

            builder.Ignore(o => o.State);
            builder.ToTable("Taxfreecar");

        }
    }
}

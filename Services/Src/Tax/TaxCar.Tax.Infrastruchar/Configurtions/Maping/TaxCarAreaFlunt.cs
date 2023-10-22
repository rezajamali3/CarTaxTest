


using CarTax.Tax.Domain;
using CarTax.Tax.Domain.ValueObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace CarTax.City.Infrastruchar.Configurtions.Maping
{
    public  class TaxCarAreaFlunt : IEntityTypeConfiguration<TaxCarArea>
    {


        public void Configure(EntityTypeBuilder<TaxCarArea> builder)
        {
            builder.HasKey(p => p.Id).HasName("TaxCarAreaId");

            builder.Property(p => p.Id)
                    .ValueGeneratedNever()
                    .HasConversion(
            CartyprId => CartyprId.Value,
                     Value => TaxCarAreaId.Create(Value))
                    .HasColumnType("Guid")
                    .HasColumnName("TaxCarAreaId");


         
          

            builder.Property(p => p.Tax)
                .HasConversion(AreaTax => AreaTax.Value,
                 Value => AreaTax.Create(Value))
                .HasColumnType("decimal(18,2)");

            builder.Property<Guid>(p => p.CarId)
                 .HasColumnType("Guid");

            builder.Property<int>(p => p.Areaid)
                .HasColumnType("int");

            builder.Property<int>(p => p.CombinedcameranumberId)
                .HasColumnType("int");
            
            builder.Ignore(o => o.State);

            builder.ToTable("TaxCarArea");

        }
    }
}

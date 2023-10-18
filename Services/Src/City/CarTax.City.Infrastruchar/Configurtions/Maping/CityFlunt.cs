

using CarTax.City.Domain;
using CarTax.City.Domain.ValueObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace CarTax.City.Infrastruchar.Configurtions.Maping
{
    public  class CityFlunt : IEntityTypeConfiguration<Citys>
    {


        public void Configure(EntityTypeBuilder<Citys> builder)
        {
            builder.HasKey(p => p.Id).HasName("CityId");

            builder.Property(p => p.Id)
                    .ValueGeneratedNever()
                    .HasConversion(
            CartyprId => CartyprId.Value,
                     Value => CityId.Create(Value))
                    .HasColumnType("int")
                    .HasColumnName("CityId");


            builder.Property(p => p.CityName)
                  .HasConversion(CityName => CityName.Value,
                               Value => CityName.Create(Name.Create(Value)))
                 .IsRequired()
                 .HasColumnType("nvarchar(60)");

            builder.Property(p => p.CityCode)
                .HasConversion(City => City.Value,
                 Value => CityCode.Create(Value))
                .HasColumnType("nvarchar(12)");

            builder.Property<bool?>(p => p.IsActive)
                 .HasColumnType("bit");

       
          

            builder.ToTable("Citys");

        }
    }
}

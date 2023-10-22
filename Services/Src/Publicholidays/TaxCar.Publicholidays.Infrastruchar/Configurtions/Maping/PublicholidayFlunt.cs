

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaxCar.Publicholiday.Domain.ValueObjects;

namespace TaxCar.Publicholidays.Infrastruchar.Configurtions.Maping
{
    public  class PublicholidayFlunt : IEntityTypeConfiguration<Publicholiday>
    {


        public void Configure(EntityTypeBuilder<Publicholiday> builder)
        {

            builder.HasKey(p => p.Id).HasName("PublicholidayId");

            builder.Property(p => p.Id)
                 .ValueGeneratedOnAdd()
                 .HasColumnType("int")
                 .HasConversion(
                   PublicholidayId => PublicholidayId.Value,
                   Value           => PublicholidayId.Create(Value)
                 );

            builder.Property(p => p.Day)
                   .IsRequired()
                   .HasColumnType("datetime");


            builder.Property(p => p.IsActive)
                .HasColumnType("bit");

            builder.Property(c => c.AreaId)
                   .HasColumnType("int");

            builder.Ignore(o => o.State);

            builder.ToTable("Publicholiday");

        }
    }
}

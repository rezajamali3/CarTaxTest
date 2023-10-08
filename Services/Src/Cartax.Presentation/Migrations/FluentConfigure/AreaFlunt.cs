
using Cartax.Domain.Domain.Citys.Entitys;
using Microsoft.EntityFrameworkCore;


namespace Cartax.Presentation.Migrations.FluentConfigure
{
    public static class AreaFlunt
    {
         
        public static ModelBuilder AreaFluntConfigure(this ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Area>(x =>
            {
                x.Property<int?>(p=>p.Id)
                    .ValueGeneratedNever()
                    .IsRequired()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(x.Property<int?>(p => p.Id));

                x.Property<string>(p => p.AreaCode)
                    .HasColumnType("nvarchar(12)");

                x.Property<string>(p => p.AreaName)
                    .HasColumnType("nvarchar(60)");

                x.HasMany(s => s.TaxCars)
                 .WithOne(g => g.Area)
                 .HasForeignKey("AreaId").OnDelete(DeleteBehavior.NoAction);


                x.HasMany(s => s.TaxTimes)
                .WithOne(g => g.Area)
                .HasForeignKey("TaxTimesId").OnDelete(DeleteBehavior.NoAction);

                x.HasKey(p => p.Id);

                x.ToTable("Area");

            });

            return modelBuilder;
        }

    }
}

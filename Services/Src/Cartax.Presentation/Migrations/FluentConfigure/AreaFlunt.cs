
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
                    .HasColumnType("nvarchar(max)");

                x.Property<string>(p => p.AreaName)
                    .HasColumnType("nvarchar(max)");

                x.HasKey(p => p.Id);

                x.ToTable("Area");

            });

            return modelBuilder;
        }

    }
}

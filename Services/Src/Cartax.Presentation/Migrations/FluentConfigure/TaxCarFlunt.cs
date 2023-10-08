
using Cartax.Domain.Entites.Tax.TaxCars;
using Microsoft.EntityFrameworkCore;


namespace Cartax.Presentation.Migrations.FluentConfigure
{
    public static class TaxCarFlunt
    {
        //public static ModelBuilder TaxCarFluntConfigure(this ModelBuilder modelBuilder)
        //{

        //    modelBuilder.Entity(typeof(TaxCar), b =>
        //    {
        //        b.Property<int?>("Id")
        //            .ValueGeneratedOnAdd()
        //            .HasColumnType("int");

        //        SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"));

        //        b.Property<DateTime?>("CreateDate")
        //            .HasColumnType("datetime2");

        //        b.Property<int?>("Idarea")
        //            .HasColumnType("int");

        //        b.Property<int?>("Idcar")
        //            .HasColumnType("int");

        //        b.Property<decimal?>("Tax")
        //            .HasColumnType("decimal(18, 2)");

        //        b.HasKey("Id");

        //        b.ToTable("TaxCar");
        //    });

        //    modelBuilder.Entity<TaxCar>()
        // .HasOne(c => c.Area)
        // .WithMany(a => a.TaxCars)
        // .HasForeignKey(a => a.Idarea);

        //    modelBuilder.Entity<TaxCar>()
        //  .HasOne(c => c.Car)
        //  .WithMany(a => a.TaxCars)
        //  .HasForeignKey(a => a.Idcar);


        //    return modelBuilder;
        //}
    }
}

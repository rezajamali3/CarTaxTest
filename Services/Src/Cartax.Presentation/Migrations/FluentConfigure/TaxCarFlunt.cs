
using Cartax.Domain.Entites.Tax.TaxCars;
using Microsoft.EntityFrameworkCore;


namespace Cartax.Presentation.Migrations.FluentConfigure
{
    public static class TaxCarFlunt 
    {
        //public static ModelBuilder TaxCarFluntConfigure(this ModelBuilder modelBuilder)
        //{

<<<<<<< HEAD
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
=======
            modelBuilder.Entity<TaxCar>( x =>
            {
                x.Property<int?>(p => p.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(x.Property<int?>(p => p.Id));

                x.Property<DateTime?>(p => p.CreateDate)
                    .HasColumnType("datetime2");

              

                x.Property<decimal?>(p => p.Tax)
                    .HasColumnType("decimal(18, 2)");

                x.HasKey(p => p.Id);

                x.ToTable("TaxCar");
            });

           
>>>>>>> 6e0109040902ca67597d3488cf835a7f8636c8fb


        //    return modelBuilder;
        //}
    }
}

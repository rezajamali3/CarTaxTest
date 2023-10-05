using Cartax.Domain.Entites.CarTypes;
using Cartax.Domain.Entites.Tax.TaxCars;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cartax.Presentation.Migrations.FluentConfigure
{
    public static class TaxCarFlunt 
    {
        public static ModelBuilder TaxCarFluntConfigure(this ModelBuilder modelBuilder)
        {

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

           


            return modelBuilder;
        }
    }
}

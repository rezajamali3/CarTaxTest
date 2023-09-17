using Cartax.Domain.Entites.Tax.TaxLongTerms;
using Cartax.Domain.Entites.Tax.TaxTimes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cartax.Presentation.Migrations.FluentConfigure
{
    public static class TaxTimeFlunt
    {
        public static ModelBuilder TaxTimeFluntConfigure(this ModelBuilder modelBuilder)
        {

            modelBuilder.Entity(typeof(TaxTime), b =>
            {
                b.Property<int?>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"));

                b.Property<TimeSpan?>("EndDate")
                    .HasColumnType("time");

                b.Property<int?>("Idarea")
                    .HasColumnType("int");

                b.Property<TimeSpan?>("StartDate")
                    .HasColumnType("time");

                b.Property<decimal?>("Tax")
                    .HasColumnType("decimal(18, 2)");

                b.HasKey("Id");

                b.ToTable("TaxTime");

                
            });

      //      modelBuilder.Entity<TaxTime>()
      //.HasOne(a => a.Area)
      //.WithOne(b => b.TaxTime)
      //.HasForeignKey<TaxTime>(c => c.Idarea)
      //  .OnDelete(DeleteBehavior.SetNull);

            return modelBuilder;
        }
    }
}

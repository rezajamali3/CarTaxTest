using Cartax.Domain.Entites.Tax.TaxLimitMoneyDays;
using Cartax.Domain.Entites.Tax.TaxLimitTimes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cartax.Presentation.Migrations.FluentConfigure
{
    public static class TaxLimitTimeFlunt
    {
        public static ModelBuilder TaxLimitTimeFluntConfigure(this ModelBuilder modelBuilder)
        {

            modelBuilder.Entity(typeof(TaxLimitTime), b =>
            {
                b.Property<int?>("Id")
                     
                    .ValueGeneratedNever()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"));

                b.Property<TimeSpan?>("Time")
                    .HasColumnType("time");

                b.Property<int?>("IdArea")
                .HasColumnType("int");

                b.HasKey("Id");

                b.ToTable("TaxLimitTime");

             
            });

            modelBuilder.Entity<TaxLimitTime>()
             .HasOne(a => a.Area)
             .WithOne(b => b.TaxLimitTime)
             .HasForeignKey<TaxLimitTime>(c => c.IdArea)
               .OnDelete(DeleteBehavior.SetNull);

            return modelBuilder;
        }
    }
}

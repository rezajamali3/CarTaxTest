using Cartax.Domain.Entites.Tax.TaxLimitDays;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cartax.Presentation.Migrations.FluentConfigure
{
    public static class TaxLimitDayFlunt
    {
        public static ModelBuilder TaxLimitDaysFluntConfigure(this ModelBuilder modelBuilder)
        {


            modelBuilder.Entity(typeof(TaxLimitDay), b =>
            {
                b.Property<int?>("Id")
                   .ValueGeneratedNever()
                    .HasColumnType("int");

                b.Property<int>("IdArea")
                  .HasColumnType("int");
                 

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"));

                b.Property<TimeSpan?>("Time")
                    .HasColumnType("time");

                b.HasKey("Id");

                b.ToTable("TaxLimitDay");
            });


            modelBuilder.Entity<TaxLimitDay>()
                .HasOne(a => a.Area)
                .WithOne(b => b.TaxLimitDay)
                .HasForeignKey<TaxLimitDay>(c => c.IdArea);
                


            return modelBuilder;
        }
    }
}


using Cartax.Domain.Domain.Citys.Entitys;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Cartax.Presentation.Migrations.FluentConfigure
{
    public static class TaxLimitMoneyDayFlunt
    {
        public static ModelBuilder TaxLimitMoneyDaysFluntConfigure(this ModelBuilder modelBuilder)
        {

            modelBuilder.Entity(typeof(TaxLimitMoneyDay), b =>
            {
                b.Property<int?>("Id")
                   .ValueGeneratedNever()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"));

                b.Property<int?>("IdArea")
                    .HasColumnType("int");

                b.Property<decimal?>("Tax")
                    .HasColumnType("decimal(18, 2)");

                b.HasKey("Id");

                b.ToTable("TaxLimitMoneyDay");

               
            });

            modelBuilder.Entity<TaxLimitMoneyDay>()
              .HasOne(a => a.Area)
              .WithOne(b => b.TaxMoneyDay)
              .HasForeignKey<TaxLimitMoneyDay>(c => c.IdArea)
                .OnDelete(DeleteBehavior.SetNull);

            return modelBuilder;
        }
    }
}

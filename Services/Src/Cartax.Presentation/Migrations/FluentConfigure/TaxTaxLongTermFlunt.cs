using Cartax.Domain.Entites.Tax.TaxLongTerms;
using Cartax.Domain.Entites.Tax.TaxPublicholidays;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cartax.Presentation.Migrations.FluentConfigure
{
    public static class TaxTaxLongTermFlunt
    {
        public static ModelBuilder TaxTaxLongTermFluntConfigure(this ModelBuilder modelBuilder)
        {

            modelBuilder.Entity(typeof(TaxTaxLongTerm), b =>
            {
                b.Property<int?>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"));

                b.Property<DateTime?>("DayEnd")
                    .HasColumnType("datetime2");

                b.Property<DateTime?>("DayStart")
                    .HasColumnType("datetime2");

                b.Property<int?>("IdArea")
                    .HasColumnType("int");

                b.HasKey("Id");

                b.ToTable("TaxTaxLongTerm");

               
            });

            modelBuilder.Entity<TaxTaxLongTerm>()
        .HasOne(a => a.Area)
        .WithOne(b => b.TaxTaxLongTerm)
        .HasForeignKey<TaxTaxLongTerm>(c => c.IdArea)
          .OnDelete(DeleteBehavior.SetNull);


            return modelBuilder;
        }
    }
}


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
    public static class TaxPublicholidayFlunt
    {
        public static ModelBuilder TaxPublicholidayFluntConfigure(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity(typeof(TaxPublicholiday), b =>
            {
                b.Property<int?>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                b.Property<int?>("IdArea")
                   .HasColumnType("int");
                
                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"));

                b.Property<DateTime?>("Day")
                    .HasColumnType("Date");

                b.Property<bool?>("IsActive")
                    .HasColumnType("bit");

                b.HasKey("Id");

                b.ToTable("TaxPublicholiday");

              
            });

         //   modelBuilder.Entity<TaxPublicholiday>()
         //.HasOne(a => a.Area)
         //.WithOne(b => b.TaxPublicholiday)
         //.HasForeignKey<TaxPublicholiday>(c => c.IdArea)
         //  .OnDelete(DeleteBehavior.SetNull);

            return modelBuilder;
        }
    }
}

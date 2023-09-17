
using Cartax.Domain.Entites.Tax.TaxLongTerms;
using Cartax.Domain.Entites.Tax.TaxTimes;
using Cartax.Domain.Entites.Tax.TaxWeekDays;
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
    public static class TaxWeekDayFlunt
    {
        public static ModelBuilder TaxWeekDayFluntConfigure(this ModelBuilder modelBuilder)
        {

            modelBuilder.Entity(typeof(TaxWeekDay), b =>
            {
                b.Property<int?>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                b.Property<int?>("IdArea")
                   .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"));

                b.Property<int>("DatyTyps")
                    .HasColumnType("int");

               

                b.Property<bool>("IsActive")
                    .HasColumnType("bit");

                b.Property<int>("TaxDays")
                    .HasColumnType("int");

                b.HasKey("Id");

                b.ToTable("TaxWeekDay");

             
            });

            modelBuilder.Entity<TaxWeekDay>()
        .HasOne(a => a.Area)
        .WithMany(b => b.TaxWeekDay)
        .HasForeignKey(c => c.IdArea)
          .OnDelete(DeleteBehavior.SetNull);


            return modelBuilder;
        }
    }
}

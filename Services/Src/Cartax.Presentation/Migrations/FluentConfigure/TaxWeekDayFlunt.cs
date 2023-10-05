

using Cartax.Domain.Domain.Citys.Entitys;
using Cartax.Domain.Entites.Tax.TaxTimes;
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

            modelBuilder.Entity<TaxWeekDay>(x =>
            {
                x.Property<int?>(p=>p.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                x.Property<int?>(p => p.IdArea)
                   .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(x.Property<int?>(p => p.Id));

                x.Property<int>(p => p.DatyTyps)
                    .HasColumnType("int");

                x.Property<bool>(p => p.IsActive)
                    .HasColumnType("bit");

                x.Property<int>(p => p.TaxDays)
                    .HasColumnType("int");

                x.HasKey(p => p.Id);

                x.ToTable("TaxWeekDay");

             
            });


            return modelBuilder;
        }
    }
}

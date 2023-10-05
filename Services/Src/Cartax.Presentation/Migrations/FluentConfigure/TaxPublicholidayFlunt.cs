
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
            modelBuilder.Entity<TaxPublicholiday>( x =>
            {
                x.Property<int?>(p => p.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

           
                
                SqlServerPropertyBuilderExtensions.UseIdentityColumn(x.Property<int?>(p => p.Id));

                x.Property<DateTime?>(p => p.Day)
                    .HasColumnType("Date");

                x.Property<bool?>(p => p.IsActive)
                    .HasColumnType("bit");

                x.HasKey(p => p.Id);

                x.ToTable("TaxPublicholiday");

              
            });

            return modelBuilder;
        }
    }
}

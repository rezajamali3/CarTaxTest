
using Cartax.Domain.Domain.Citys.Entitys;

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

            modelBuilder.Entity<TaxTaxLongTerm>(x =>
            {
                x.Property<int?>(p => p.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(x.Property<int?>(p => p.Id));

                x.Property<DateTime?>(p => p.DayEnd)
                    .HasColumnType("datetime2");

                x.Property<DateTime?>(p => p.DayStart)
                    .HasColumnType("datetime2");

            

                x.HasKey(p => p.Id);

                x.ToTable("TaxTaxLongTerm");

               
            });

           


            return modelBuilder;
        }
    }
}

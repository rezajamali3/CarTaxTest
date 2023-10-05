
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
    public static class TaxTimeFlunt
    {
        public static ModelBuilder TaxTimeFluntConfigure(this ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<TaxTime>( x =>
            {
                x.Property<int?>(p => p.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(x.Property<int?>(p => p.Id));

                x.Property<TimeSpan?>(p => p.EndDate)
                    .HasColumnType("time");

               

                x.Property<TimeSpan?>(p => p.StartDate)
                    .HasColumnType("time");

                x.Property<decimal?>(p => p.Tax)
                    .HasColumnType("decimal(18, 2)");

                x.HasKey(p => p.Id);

                x.ToTable("TaxTime");

                
            });

  

            return modelBuilder;
        }
    }
}

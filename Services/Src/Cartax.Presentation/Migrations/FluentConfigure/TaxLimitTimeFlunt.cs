
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
    public static class TaxLimitTimeFlunt
    {
        public static ModelBuilder TaxLimitTimeFluntConfigure(this ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<TaxLimitTime>( x =>
            {
                x.Property<int?>(p => p.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(x.Property<int?>(p => p.Id));

                x.Property<TimeSpan?>(p => p.Time)
                    .HasColumnType("time");

                x.HasKey(p => p.Id);

                x.ToTable("TaxLimitTime");

             
            });

         

            return modelBuilder;
        }
    }
}

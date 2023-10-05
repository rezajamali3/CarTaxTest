
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

            modelBuilder.Entity<TaxLimitMoneyDay>( x =>
            {
                x.Property<int?>(p => p.Id)
                   .ValueGeneratedNever()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(x.Property<int?>(p=>p.Id));

             

                x.Property<decimal?>(p => p.Tax)
                    .HasColumnType("decimal(18, 2)");

                x.HasKey(p => p.Id);

               x.ToTable("TaxLimitMoneyDay");

               
            });

          

            return modelBuilder;
        }
    }
}

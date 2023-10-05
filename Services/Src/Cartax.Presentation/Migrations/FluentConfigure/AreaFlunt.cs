
using Cartax.Domain.Domain.Citys.Entitys;
using MathNet.Numerics.Distributions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using NPOI.SS.Formula.Functions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Cartax.Presentation.Migrations.FluentConfigure
{
    public static class AreaFlunt
    {
         
        public static ModelBuilder AreaFluntConfigure(this ModelBuilder modelBuilder)
        {

            modelBuilder.Entity(typeof(Area), b =>
            {
                b.Property<int?>("Id")
                    .ValueGeneratedNever()
                    .IsRequired()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"));

                b.Property<string>("AreaCode")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("AreaName")
                    .HasColumnType("nvarchar(max)");

                b.HasKey("Id");

                b.ToTable("Area");

            });

            return modelBuilder;
        }

    }
}

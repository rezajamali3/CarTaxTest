

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaxCar.Combinedstation.Core;

namespace CarTax.Combinedstation.Infrastruchar.Configurtions.Maping
{
    public  class CombinedStationFlunt : IEntityTypeConfiguration<CombinedStations>
    {


        public void Configure(EntityTypeBuilder<CombinedStations> builder)
        {

            builder.HasKey(p => p.CombinedStationsId).HasName("CombinedStationsId");

            builder.Property<Guid>(p => p.CombinedStationsId)
                 .ValueGeneratedOnAdd()
                 .HasColumnName("CombinedStationsId")
                 .HasColumnType("uniqueidentifier") ;


            builder.Property(p => p.StationName)
             .HasColumnType("nvarchar(60)");


            builder.Property(p => p.StationCode)
              .HasColumnType("nvarchar(3)");

            builder.Property(p => p.IsActive)
                .HasColumnType("bit");

            builder.ToTable("CombinedStations");

        }
    }
}

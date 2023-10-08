using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cartax.Domain.Entites.Citys;

namespace Cartax.Presentation.Data.EntitiesConfig
{
    public class CityDataConfiguertions : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {


            SeedData(builder);
        }

        private void SeedData(EntityTypeBuilder<City> builder)
        {


            var cities = DataDefultConfig();

            if (DataExists(builder) == false)
            {
                foreach (var city in cities)
                {
                    builder.HasData(city);
                }


            }
        }

        private bool DataExists(EntityTypeBuilder<City> builder)
        {
            // بررسی وجود داده در جدول
            return builder.Metadata.GetSeedData().Any();
        }

        public IEnumerable<City> DataDefultConfig()
        {
            IEnumerable<City> city = new City[]
            {
                 City.Create(1,"Gothenburg","FitNet10"),
                  City.Create(2,"Eroica","FitNet45"),
                   City.Create(3,"Avesta","FitNet48"),
            };

            return city;
        }


    }
}

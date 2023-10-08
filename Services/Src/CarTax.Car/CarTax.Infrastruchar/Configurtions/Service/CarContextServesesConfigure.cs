
using Cartax.Presentation.Base;
using CarTax.Car.Infrastruchar;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarTax.Car.Infrastruchar.Configurtions.Service
{
    public static class CarContextServesesConfigure
    {

        public static IServiceCollection PersistenceServesiesConfigure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<CarDBContext>(
                option =>
                {
                    option.UseSqlServer(configuration.GetConnectionString("Car_ConnectionsStrings"));
                }
            );

            return services;
        }

    }
}

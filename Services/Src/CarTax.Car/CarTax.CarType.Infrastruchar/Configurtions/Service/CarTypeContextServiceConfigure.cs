
using CarTax.Car.Infrastruchar;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxCar.CarType.Infrastruchar.Configurtions.Service
{
    public static class CarTypeContextServiceConfigure
    {

        public static IServiceCollection DBContextServesiesConfigure(this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddDbContext<CarTypeDBContext>(
                option =>
                {
                    option.UseSqlServer(configuration.GetConnectionString("CarType_ConnectionsStrings"),
                        settings => settings.EnableRetryOnFailure().CommandTimeout(60));
                   option.EnableSensitiveDataLogging();
                }
            );

            return services;
        }

    }
}

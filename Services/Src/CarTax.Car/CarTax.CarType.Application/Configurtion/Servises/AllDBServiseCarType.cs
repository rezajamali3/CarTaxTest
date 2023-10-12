using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarTax.Car.Infrastruchar.Configurtions.Service;
using CarTax.CarType.Infrastruchar.Configurtions.Service;
using Microsoft.Extensions.Configuration;

namespace CarTax.CarType.Application.Configurtion.Servises
{
    public static class AllDBServiseCarType
    {
        public static IServiceCollection AllDBServiseCarTypeConfig(
       this IServiceCollection services,
            IConfiguration     configuration )
        {

            services.DBContextServesiesConfigure(configuration)
                    .CarTypeApplicationServiceConfig()
                    .CarTypeRepositoryServiceConfig()
                    .UnitOfWorkServiceConfig();


            return services;
        }
    }
}

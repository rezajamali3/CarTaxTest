


using Microsoft.Extensions.DependencyInjection;

using CarTax.Car.Infrastruchar.Configurtions.Service;
using Microsoft.Extensions.Configuration;
using Library_Dapper;
using CarTax.Car.Infrastruchar.Configurtions.Service;

namespace TaxCar.Car.Applaication.Configgurtions.Services
{
    public static class ServicesConfigurtions
    {
        public static IServiceCollection InfrastrucharservicesConfig(this IServiceCollection services,
            IConfiguration configuration)
        {

            services.DBContextServesiesConfigure(configuration)
                    .CarRepositoryServiceConfig()
                    .UnitOfWorkServiceConfig()
                    .QueryContextConfig(configuration.GetConnectionString("Car_ConnectionsStrings"));

            
            return services;
        }
    }
}

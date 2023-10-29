


using Microsoft.Extensions.DependencyInjection;

using CarTax.City.Infrastruchar.Configurtions.Service;
using Microsoft.Extensions.Configuration;
using Library_Dapper;


namespace CarTax.City.Infrastruchar.Configurtions.Service
{
    public static class ServicesConfigurtions
    {
        public static IServiceCollection InfrastrucharservicesConfig(this IServiceCollection services,
            IConfiguration configuration)
        {

            services.DBContextServesiesConfigure(configuration)
                    .CityRepositoryServiceConfig()
                    .UnitOfWorkServiceConfig()
                    .QueryContextConfig(configuration.GetConnectionString("Car_ConnectionsStrings"));

            
            return services;
        }
    }
}

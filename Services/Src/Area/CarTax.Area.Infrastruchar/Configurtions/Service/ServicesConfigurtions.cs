


using Microsoft.Extensions.DependencyInjection;

using CarTax.Area.Infrastruchar.Configurtions.Service;
using Microsoft.Extensions.Configuration;
using Library_Dapper;

namespace TaxCar.Area.Applaication.Configgurtions.Services
{
    public static class ServicesConfigurtions
    {
        public static IServiceCollection InfrastrucharservicesConfig(this IServiceCollection services,
            IConfiguration configuration)
        {

            services.DBContextServesiesConfigure(configuration)
                    .AreaRepositoryServiceConfig()
                    .UnitOfWorkServiceConfig()
                    .QueryContextConfig(configuration.GetConnectionString("Area_ConnectionsStrings"));

            
            return services;
        }
    }
}

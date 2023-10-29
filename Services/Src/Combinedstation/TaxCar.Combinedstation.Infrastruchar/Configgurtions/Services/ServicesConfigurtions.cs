using Microsoft.Extensions.DependencyInjection;

using Microsoft.Extensions.Configuration;
using Library_Dapper;

namespace TaxCar.Combinedstation.Infrastruchar.Configurtions.Services
{
    public static class ServicesConfigurtions
    {
        public static IServiceCollection  InfrastrucharservicesConfig(this IServiceCollection services,IConfiguration configuration)
        {

            services.DBContextServesiesConfigure(configuration)
                    .CombinedstationRepositoryServiceConfig()
                    .QueryContextConfig(configuration.GetConnectionString("Combinedstation_ConnectionsStrings"));



            return services;
        }
    }
}

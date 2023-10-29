
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Library_Dapper;

namespace TaxCar.Tax.Infrastruchar.Configurtions.Service
{
    public static class ServicesConfigurtions
    {
        public static IServiceCollection InfrastrucharservicesConfig(this IServiceCollection services,
            IConfiguration configuration)
        {

            services.DBContextServesiesConfigure(configuration)
                    .TaxCarAreaRepositoryServiceConfig()
                    .UnitOfWorkServiceConfig()
                    .QueryContextConfig(configuration.GetConnectionString("Publicholidays_ConnectionsStrings"));

            
            return services;
        }
    }
}

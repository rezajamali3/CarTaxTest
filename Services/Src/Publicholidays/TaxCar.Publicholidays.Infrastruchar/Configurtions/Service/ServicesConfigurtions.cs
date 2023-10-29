
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Library_Dapper;

namespace CarTax.Publicholidays.Infrastruchar.Configurtions.Service
{
    public static class ServicesConfigurtions
    {
        public static IServiceCollection InfrastrucharservicesConfig(this IServiceCollection services,
            IConfiguration configuration)
        {

            services.DBContextServesiesConfigure(configuration)
                    .PublicholidayRepositoryServiceConfig()
                    .UnitOfWorkServiceConfig()
                    .QueryContextConfig(configuration.GetConnectionString("Publicholidays_ConnectionsStrings"));

            
            return services;
        }
    }
}

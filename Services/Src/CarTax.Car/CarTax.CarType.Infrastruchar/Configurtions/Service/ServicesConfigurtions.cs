
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Library_Dapper;




namespace TaxCar.CarType.Infrastruchar.Configurtions.Service
{
    public static class ServicesConfigurtions
    {
        public static IServiceCollection InfrastrucharservicesConfig(this IServiceCollection services,
            IConfiguration configuration)
        {

            services.DBContextServesiesConfigure(configuration)
                    .CarTypeRepositoryServiceConfig()
                    .UnitOfWorkServiceConfig()
                    .QueryContextConfig(configuration.GetConnectionString("CarTax_ConnectionsStrings"));

            
            return services;
        }
    }
}

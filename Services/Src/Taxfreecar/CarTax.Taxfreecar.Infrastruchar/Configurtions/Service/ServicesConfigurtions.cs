
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Library_Dapper;




namespace CarTax.Taxfreecar.Infrastruchar.Configurtions.Service
{
    public static class ServicesConfigurtions
    {
        public static IServiceCollection InfrastrucharservicesConfig(this IServiceCollection services,
            IConfiguration configuration)
        {

            services.DBContextServesiesConfigure(configuration)
                    .TaxfreecarRepositoryServiceConfig()
                    .UnitOfWorkServiceConfig()
                    .QueryContextConfig(configuration.GetConnectionString("Taxfreecar_ConnectionsStrings"));

            
            return services;
        }
    }
}

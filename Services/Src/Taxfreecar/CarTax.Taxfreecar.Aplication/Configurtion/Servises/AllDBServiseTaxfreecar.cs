using Microsoft.Extensions.DependencyInjection;
using CarTax.Taxfreecar.Infrastruchar.Configurtions.Service;
using Microsoft.Extensions.Configuration;

namespace CarTax.Taxfreecar.Aplication.Configurtion.Servises
{ 
    public static class AllDBServiseTaxfreecar
    {
        public static IServiceCollection AllDBServiseTaxfreecarConfig(
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

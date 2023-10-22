

using CarTax.Taxfreecar.Infrastruchar.Repositories;
using Microsoft.Extensions.DependencyInjection;



namespace CarTax.Taxfreecar.Infrastruchar.Configurtions.Service
{
    public static class TaxfreecarRepositoryServiceConfigure
    {
        public static IServiceCollection CarTypeRepositoryServiceConfig(this IServiceCollection services)
        {

            services.AddScoped<TaxfreecarRepository, TaxfreecarRepository>();

            return services;
        }
    }
}

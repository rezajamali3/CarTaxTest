


using CarTax.City.Domain.Repositorys;
using CarTax.Tax.Infrastruchar.Repositories;
using Microsoft.Extensions.DependencyInjection;



namespace CarTax.Tax.Infrastruchar.Configurtions.Service
{
    public static class TaxCarAreaRepositoryServiceConfigure
    {
        public static IServiceCollection CarTypeRepositoryServiceConfig(this IServiceCollection services)
        {

            services.AddScoped<ITaxCarAreaRepository, TaxCarAreaRepository>();

            return services;
        }
    }
}

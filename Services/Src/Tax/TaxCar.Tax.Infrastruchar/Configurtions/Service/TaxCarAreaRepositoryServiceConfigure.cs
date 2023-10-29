



using CarTax.Tax.Domain.Repositorys;
using CarTax.Tax.Infrastruchar.Repositories;
using Microsoft.Extensions.DependencyInjection;



namespace TaxCar.Tax.Infrastruchar.Configurtions.Service
{
    public static class TaxCarAreaRepositoryServiceConfigure
    {
        public static IServiceCollection TaxCarAreaRepositoryServiceConfig(this IServiceCollection services)
        {

            services.AddScoped<ITaxCarAreaRepository, TaxCarAreaRepository>();

            return services;
        }
    }
}

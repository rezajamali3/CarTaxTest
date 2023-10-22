




using Microsoft.Extensions.DependencyInjection;
using TaxCar.Publicholidays.Domain.Repository;
using TaxCar.Publicholidays.Infrastruchar.Repositories;

namespace TaxCar.Publicholidays.Infrastruchar.Configurtions.Service
{
    public static class PublicholidayRepositoryServiceConfigure
    {
        public static IServiceCollection PublicholidayRepositoryServiceConfig(this IServiceCollection services)
        {

            services.AddScoped<IPublicholidayRepository, PublicholidayRepository>();

            return services;

        }
    }
}

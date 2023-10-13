

using CarTax.Car.Domain.Repository;
using CarTax.Car.Infrastruchar.Repositories;
using Microsoft.Extensions.DependencyInjection;



namespace CarTax.Car.Infrastruchar.Configurtions.Service
{
    public static class CarRepositoryServiceConfigure
    {
        public static IServiceCollection CarRepositoryServiceConfig(this IServiceCollection services)
        {

            services.AddScoped<ICarRepository, CarRepository>();

            return services;

        }
    }
}

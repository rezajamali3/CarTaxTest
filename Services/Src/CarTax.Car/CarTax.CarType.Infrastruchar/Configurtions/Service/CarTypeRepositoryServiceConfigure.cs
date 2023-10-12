


using CarTax.Car.Application;
using CarTax.CarType.Domain.Repositorys;
using CarTax.CarType.Infrastruchar;
using CarTax.CarType.Infrastruchar.Repositories;
using Microsoft.Extensions.DependencyInjection;



namespace CarTax.Car.Infrastruchar.Configurtions.Service
{
    public static class CarTypeRepositoryServiceConfigure
    {
        public static IServiceCollection CarTypeRepositoryServiceConfig(this IServiceCollection services)
        {

            services.AddScoped<ICarTypeRepository, CarTaypsRepository>();

            return services;
        }
    }
}

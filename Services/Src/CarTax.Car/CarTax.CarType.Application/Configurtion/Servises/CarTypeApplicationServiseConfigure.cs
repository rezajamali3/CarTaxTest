﻿


using CarTax.Car.Application;
using CarTax.CarType.Application;
using CarTax.CarType.Domain.Repositorys;
using CarTax.CarType.Infrastruchar;
using CarTax.CarType.Infrastruchar.Repositories;
using Microsoft.Extensions.DependencyInjection;



namespace CarTax.Car.Infrastruchar.Configurtions.Service
{
    public static class CarTypeApplicationServiseConfigure
    {
        public static IServiceCollection CarTypeApplicationServiceConfig(this IServiceCollection services)
        {




            services.AddScoped(c =>
               new CarTypeApplicationService(
                   c.GetService<ICarTypeRepository>(),
                   c.GetService<IUnitOfWork>()));

          

            return services;
        }
    }
}

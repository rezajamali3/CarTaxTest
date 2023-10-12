


using CarTax.Car.Application;
using CarTax.Car.Domain.Repository;
using CarTax.CarType.Domain.Repositorys;
using Microsoft.Extensions.DependencyInjection;



namespace CarTax.Car.Application.Configurtion.Servises
{
    public static class CarApplicationServiseConfigure
    {
        public static IServiceCollection CarTypeApplicationServiceConfig(this IServiceCollection services)
        {




            services.AddScoped(c =>
               new CarApplicationService(
                   c.GetService<ICarRepository>(),
                   c.GetService<IUnitOfWork>()));

          

            return services;
        }
    }
}

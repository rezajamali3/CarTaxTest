




using CarTax.Car.Domain.Repository;
using Microsoft.Extensions.DependencyInjection;



namespace CarTax.Car.Application.Configurtion.Servises
{
    public static class CarApplicationServiseConfigure
    {
        public static IServiceCollection CarApplicationServiceConfig(this IServiceCollection services)
        {

            services.AddScoped(c =>
               new CarApplicationService
               (

                   c.GetService<ICarRepository>(),
                   c.GetService<IUnitOfWork>())

               );

            return services;

        }
    }
}

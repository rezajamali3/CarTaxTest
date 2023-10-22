

using CarTax.Area.Application;
using CarTax.Area.Domain.Repository;
using Library_EF;
using Microsoft.Extensions.DependencyInjection;



namespace CarTax.Car.Application.Configurtion.Servises
{
    public static class AreaApplicationServiseConfigure
    {
        public static IServiceCollection AreaApplicationServiceConfig(this IServiceCollection services)
        {

            services.AddScoped(c =>
               new AreaApplicationService
               (

                   c.GetService<IAreaRepository>(),
                   c.GetService<IUnitOfWork>())

               );

            return services;

        }
    }
}

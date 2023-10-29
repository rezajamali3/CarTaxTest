



using CarTax.CarType.Application;
using CarTax.CarType.Domain.Repositorys;
using Library_EF;
using Microsoft.Extensions.DependencyInjection;



namespace CarTax.CarType.Application.Configurtions.Service
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

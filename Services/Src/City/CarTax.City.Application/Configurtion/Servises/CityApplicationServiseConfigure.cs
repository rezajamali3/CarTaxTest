



using CarTax.CarType.Application;
using CarTax.City.Domain.Repositorys;
using Library_EF;
using Microsoft.Extensions.DependencyInjection;



namespace CarTax.City.Infrastruchar.Configurtions.Service
{
    public static class CityApplicationServiseConfigure
    {
        public static IServiceCollection CarTypeApplicationServiceConfig(this IServiceCollection services)
        {




            services.AddScoped(c =>
               new CityApplicationService(
                   c.GetService<ICityRepository>(),
                   c.GetService<IUnitOfWork>()));

          

            return services;
        }
    }
}

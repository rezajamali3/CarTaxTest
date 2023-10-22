

using CarTax.Publicholiday.Application;
using Library_EF;
using Microsoft.Extensions.DependencyInjection;
using TaxCar.Publicholidays.Domain.Repository;

namespace TaxCar.Publicholidays.Application.Configurtion.Servises
{
    public static class PublicholidayApplicationServiseConfigure
    {
        public static IServiceCollection PublicholidayApplicationServiceConfig(this IServiceCollection services)
        {

            services.AddScoped(c =>
               new PublicholidayApplicationService(
                   c.GetService<IPublicholidayRepository>(),
                   c.GetService<IUnitOfWork>()));

            return services;
        }
    }
}

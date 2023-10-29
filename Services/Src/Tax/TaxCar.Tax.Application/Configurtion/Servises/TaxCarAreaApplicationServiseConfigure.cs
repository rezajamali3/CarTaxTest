


using CarTax.Tax.Domain.Repositorys;
using Library_EF;
using Microsoft.Extensions.DependencyInjection;
using TaxCar.Tax.Application;

namespace TaxCar.Tax.Application.Configurtion.Servises
{
    public static class TaxCarAreaApplicationServiseConfigure
    {
        public static IServiceCollection TaxCarAreaApplicationServiceConfig(this IServiceCollection services)
        {

            services.AddScoped(c =>
               new TaxCarAreaApplicationService
               (
                   c.GetService<ITaxCarAreaRepository>(),
                   c.GetService<IUnitOfWork>())
               );

            return services;

        }
    }
}



using CarTax.Taxfreecar.Domain.Repositorys;
using Library_EF;
using Microsoft.Extensions.DependencyInjection;



namespace CarTax.Taxfreecar.Aplication.Configurtion.Servises
{
    public static class TaxfreecarApplicationServiseConfigure
    {
        public static IServiceCollection TaxfreecarApplicationServiceConfig(this IServiceCollection services)
        {




            services.AddScoped(c =>
               new TaxfreecarApplicationService(
                   c.GetService<ITaxfreecarRepository>(),
                   c.GetService<IUnitOfWork>()));

          

            return services;
        }
    }
}

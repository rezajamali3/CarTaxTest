using Cartax.Applications.Base;
using Cartax.Applications.Persistence.Repositories;
using Cartax.Presentation.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cartax.Presentation.Configurtions
{
    public static class PersistenceCarTaxContextServesesConfigure
    {

        public static IServiceCollection PersistenceServesiesConfigure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<CarTaxContext>(
                option =>
                {
                    option.UseSqlServer(configuration.GetConnectionString("CarTax_ConnectionsStrings"));
                }
            );

            services.AddScoped(typeof(IAsyncRepository<>), typeof(RepositoryBase<>));

          

            return services;
        }

    }
}

using Cartax.Applications.Common.Base;
using Cartax.Applications.Common.Intercpter;
using Cartax.Domain.Common.Primitives;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cartax.Applications.Configure
{
    public static class EventHandlrConfigure
    {
        public static IServiceCollection EventHandlrConfigureServeces(this IServiceCollection services)
        {
            services.AddScoped<IDomainEventAdd, PublishDomainEventIntercpter>();
            return services;


        }
    }
}

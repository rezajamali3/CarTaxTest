using Cartax.Applications.Base;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Cartax.Applications.Configure
{
    public static class MediatRConfigure
    {
        public static IServiceCollection MediatRConfigureApplicationsServeces(this IServiceCollection services)
        {
            services.AddMediatR(Assembly.GetExecutingAssembly());
            return services;
        }
    }
}

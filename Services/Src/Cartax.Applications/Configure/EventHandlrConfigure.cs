using Cartax.Applications.Common.Base;
using Cartax.Applications.Common.Intercpter;
using Library_Domain.Interface;
using Microsoft.Extensions.DependencyInjection;


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

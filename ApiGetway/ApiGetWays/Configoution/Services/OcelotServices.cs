using Microsoft.AspNetCore.HttpLogging;
using Ocelot.DependencyInjection;
using Ocelot.Middleware;

namespace ApiGetWays.Configoution.Services
{
    public static class OcelotServices
    {
        public static IServiceCollection OcelotConfig(this IServiceCollection services,WebApplicationBuilder builder)
        {

            builder.Configuration.SetBasePath(builder.Environment.ContentRootPath)
             .AddJsonFile("ocelot.json", optional: false, reloadOnChange: true);

            services.AddOcelot(builder.Configuration);
         

            return services;
        }


        public static WebApplication OcelotApp(this  WebApplication app)
        {

            app.UseOcelot().Wait();

            return app;
        }
    }
}

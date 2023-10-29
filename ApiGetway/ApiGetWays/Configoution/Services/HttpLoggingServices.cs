using Microsoft.AspNetCore.HttpLogging;
using Ocelot.Middleware;

namespace ApiGetWays.Configoution.Services
{
    public static class HttpLoggingServices
    {
        public static IServiceCollection HttpLoggingConfig(this IServiceCollection services)
        {

            services.AddHttpLogging(logging =>
            {

                logging.LoggingFields = HttpLoggingFields.All;
                logging.RequestHeaders.Add("sec-ch-ua");
                logging.ResponseHeaders.Add("MyResponseHeader");
                logging.MediaTypeOptions.AddText("application/javascript");
                logging.RequestBodyLogLimit = 4096;
                logging.ResponseBodyLogLimit = 4096;

            });


            return services;
        }


        public static WebApplicationBuilder LoggingConfig(this WebApplicationBuilder builder)
        {

            builder.Logging.ClearProviders();
            builder.Logging.AddConsole();
            builder.Logging.AddDebug();

            return builder;
        }
    }
}

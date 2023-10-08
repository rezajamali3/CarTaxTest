
using Cartax.Applications.Persistence.Repositories;
using Cartax.Presentation;
using Cartax.WebAPI.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Any;
using Microsoft.OpenApi.Models;

namespace Cartax.WebAPI.Configotions
{
    public static class SwaggerGenConfigure
    {
        public static IServiceCollection SwaggerGenConfig(this IServiceCollection services)
        {


            services.AddSwaggerGen(options =>
            {
                options.SchemaFilter<TimeSpanSchemaFilter>();
            });

         

            return services;
        }
    }
}

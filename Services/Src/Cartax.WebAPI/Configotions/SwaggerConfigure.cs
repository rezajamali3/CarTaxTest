using Microsoft.OpenApi.Any;
using Microsoft.OpenApi.Models;

namespace Cartax.WebAPI.Configotions
{
    public static class SwaggerConfigures
    {
        public static WebApplication SwaggerConfig(this WebApplication web)
        {
         
            web.UseSwaggerUI();
          

            return web;

        }
    }

}
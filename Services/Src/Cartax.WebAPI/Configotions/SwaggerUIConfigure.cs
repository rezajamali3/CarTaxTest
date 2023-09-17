namespace Cartax.WebAPI.Configotions
{
    public static class SwaggerUIConfigure
    {
        public static WebApplication SwaggerUiConfig(this WebApplication web)
        {
        
            web.UseSwaggerUI();


            return web;

        }
    }
}

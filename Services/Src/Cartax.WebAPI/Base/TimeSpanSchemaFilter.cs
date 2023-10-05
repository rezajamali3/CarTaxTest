using Microsoft.OpenApi.Any;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace Cartax.WebAPI.Base
{
    public class TimeSpanSchemaFilter : ISchemaFilter
    {

        public void Apply(OpenApiSchema schema, SchemaFilterContext context)
        {
            if (context.Type == typeof(TimeSpan))
            {
                schema.Type = "string";
                schema.Example = new OpenApiString("00:00:00");
            }
        }


    }
}

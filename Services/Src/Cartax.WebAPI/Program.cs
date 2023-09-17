using Cartax.Presentation.Configurtions;
using Cartax.Applications.Configure;
using Microsoft.OpenApi.Any;
using Microsoft.OpenApi.Models;
using Cartax.WebAPI.Configotions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();




builder.Services
       .PersistenceServesiesConfigure(builder.Configuration)
       .BaseAllRepositoryDatabaserConfigure()
       .AutoMapperApplicationsServeces()
       .MediatRConfigureApplicationsServeces()
       .SwaggerGenConfig();

var app = builder.Build();


    app.UseSwagger()
       .UseSwaggerUI();




app.UseAuthorization();
app.Services.MigrateDatabase();
app.MapControllers();

app.Run();

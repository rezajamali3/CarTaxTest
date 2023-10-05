using Cartax.Presentation.Configurtions;
using Cartax.Applications.Configure;
using Microsoft.OpenApi.Any;
using Microsoft.OpenApi.Models;
using Cartax.WebAPI.Configotions;
using MediatR;
using Cartax.Domain.Common.Primitives;
using Cartax.Applications.Common.Intercpter;
using Cartax.Applications.Features.TaxCar.Event;
using Cartax.Domain.Domain.Tax.Event;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();

builder.Services
       .PersistenceServesiesConfigure(builder.Configuration)
       .BaseAllRepositoryDatabaserConfigure()
       .AutoMapperApplicationsServeces()
       .MediatRConfigureApplicationsServeces()
       .SwaggerGenConfig()
       .EventHandlrConfigureServeces();

var app = builder.Build();

   
app.UseSwagger()
   .UseSwaggerUI();


app.UseAuthorization();
app.Services.MigrateDatabase();
app.MapControllers();

app.Run();

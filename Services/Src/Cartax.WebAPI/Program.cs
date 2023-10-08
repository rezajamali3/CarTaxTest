
using Cartax.Presentation.Configurtions;
using Cartax.Applications.Configure;
using Cartax.WebAPI.Configotions;

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

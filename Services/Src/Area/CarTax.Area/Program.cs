


using CarTax.Area.Infrastruchar.Configurtions.Service;
using TaxCar.Area.Applaication.Configgurtions.Services;
using TaxCar.Area.Presentation.Configgurtions.Services;

var builder = WebApplication
    .CreateBuilder(args);







builder
    .Services
    .AddControllers();

builder
    .Services
    .AddEndpointsApiExplorer();

builder
    .Services
    .AddSwaggerGen();

builder.Services.InfrastrucharservicesConfig(builder.Configuration)
    .ApplaicationservicesConfig()
    .PresentationservicesConfig();







var app = builder.Build();


app.UseSwagger();
app.UseSwaggerUI();


app.UseAuthorization();

app.MapControllers();
app.Services.MigrateDatabase();

app.Run();

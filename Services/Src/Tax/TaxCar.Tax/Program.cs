

using TaxCar.Tax.Infrastruchar.Configurtions.Service;
using TaxCar.Tax.Application.Configurtion.Servises;
using CarTax.Tax.Application.Configurtion.Servises;

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

builder.Services
    .InfrastrucharservicesConfig(builder.Configuration)
    .ApplaicationservicesConfig();


var app = builder
    .Build();


app
    .UseSwagger();

app
    .UseSwaggerUI();


app
    .UseAuthorization();

app
    .MapControllers();
app
    .Services
    .MigrateDatabase();

app.Run();


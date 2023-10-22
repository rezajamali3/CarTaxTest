


using CarTax.Area.Infrastruchar.Configurtions.Service;
using CarTax.Area.Application.Configurtion.Servises;
using System.Drawing;
using Microsoft.Extensions.Configuration;

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
    .DBContextServesiesConfigure(builder.Configuration)
    .AllDBServiseAreaConfig(builder.Configuration);

var app = builder.Build();


app.UseSwagger();
app.UseSwaggerUI();


app.UseAuthorization();

app.MapControllers();
app.Services.MigrateDatabase();

app.Run();

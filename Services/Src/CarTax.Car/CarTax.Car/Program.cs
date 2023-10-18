


using CarTax.Car.Infrastruchar.Configurtions.Service;
using CarTax.Car.Application.Configurtion.Servises;
using System.Drawing;
using Microsoft.Extensions.Configuration;

var builder = WebApplication
    .CreateBuilder(args);


string? st= builder.Configuration.GetConnectionString("Car_ConnectionsStrings");

var st12 = builder.Configuration.GetSection("Logging:LogLevel");

string? st13 = st12.GetValue<string>("Default");

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
    .AllDBServiseCarConfig(builder.Configuration);

var app = builder.Build();

// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
    app.UseSwagger();
    app.UseSwaggerUI();
//}




app.UseAuthorization();

app.MapControllers();
app.Services
    .MigrateDatabase();

app.Run();

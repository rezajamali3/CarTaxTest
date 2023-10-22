


using TaxCar.Publicholidays.Infrastruchar.Configurtions.Service;
using TaxCar.Publicholidays.Application.Configurtion.Servises;
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
    .AllDBServisePublicholidayConfig(builder.Configuration);

var app = builder.Build();

// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
app.UseSwagger();
app.UseSwaggerUI();
//}




app.UseAuthorization();

app.MapControllers();
app.Services.MigrateDatabase();

app.Run();

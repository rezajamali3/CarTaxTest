


using CarTax.Car.Infrastruchar.Configurtions.Service;
using CarTax.Car.Application.Configurtion.Servises;

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

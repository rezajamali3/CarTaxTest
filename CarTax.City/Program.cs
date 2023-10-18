
using CarTax.City.Application.Configurtion.Servises;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AllDBServiseCarTypeConfig(builder.Configuration);

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();


app.UseAuthorization();
app.Services.MiggrationDatabaseServise();
app.MapControllers();

app.Run();


using CarTax.Taxfreecar.Aplication.Configurtion.Servises;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AllDBServiseTaxfreecarConfig(builder.Configuration);

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();


app.UseAuthorization();
app.Services.MiggrationDatabaseServise();
app.MapControllers();

app.Run();

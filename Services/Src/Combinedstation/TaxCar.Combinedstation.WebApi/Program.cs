
using TaxCar.Combinedstation.Presentation.Configgurtions.Services;
using TaxCar.Combinedstation.Applaication.Configgurtions.Services;
using TaxCar.Combinedstation.Infrastruchar.Configurtions.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services
    .InfrastrucharservicesConfig(builder.Configuration)
    .ApplaicationservicesConfig()
    .PresentationservicesConfig();



var app = builder.Build();


app.UseSwagger();
app.UseSwaggerUI();


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();
app.Services.MigrateDatabase();
app.Run();

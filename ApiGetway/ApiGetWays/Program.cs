


using ApiGetWays.Configoution.Services;


var builder = WebApplication.CreateBuilder(args);
builder.LoggingConfig();


builder.Services.HttpLoggingConfig()
       .OcelotConfig(builder);

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.OcelotApp();


app.Run();

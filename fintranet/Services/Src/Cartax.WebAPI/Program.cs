using Cartax.Presentation.Configurtions;
using Cartax.Applications.Configure;


var builder = WebApplication.CreateBuilder(args);




builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();




builder.Services
       .PersistenceServesiesConfigure(builder.Configuration)
       .BaseAllRepositoryDatabaserConfigure()
       .AutoMapperApplicationsServeces()
       .MediatRConfigureApplicationsServeces();
                 

var app = builder.Build();





// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
    app.UseSwagger();
    app.UseSwaggerUI();
//}



app.UseAuthorization();
app.Services.MigrateDatabase();
app.MapControllers();

app.Run();

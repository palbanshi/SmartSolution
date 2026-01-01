using Smartsolutions.API;
using Smartsolutions.API.Controllers;
using Smartsolutions.Infrastructure.Extensions;
using Smartsolutions.Infrastructure.Persistence;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
//new changes 
builder.Services.AddScoped<IWeatherForecastService,WeatherForecastService>();

builder.Services.AddInfrastructure(builder.Configuration);

var app = builder.Build();
var scope=app.Services.CreateScope();
var seeder=scope.ServiceProvider.GetRequiredService<ISmartsolutionsSeeders>();
await seeder.Seed();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

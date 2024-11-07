using MercanlarApi.cqrs.Handlers.CommandHandlers;
using MercanlarApi.cqrs.Handlers.QueryHandlers;
using MercanlarApi.Database;
using MercanlarApi.Database.Entities;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Configure services
builder.Services.AddTransient<CreateAracCommandHandler>();
builder.Services.AddTransient<DeleteAracCommandHandler>();
builder.Services.AddTransient<GetAllAracQueryHandler>();
builder.Services.AddTransient<GetAracByPlakaQueryHandler>();
builder.Services.AddControllers();
builder.Services.AddDbContext<MercanDb>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddScoped<AracService>();
// Add Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Apply migrations and create the database
using (var scope = app.Services.CreateScope())
{
    var MercanlarDb = scope.ServiceProvider.GetRequiredService<MercanDb>();
    MercanlarDb.Database.Migrate(); // This will apply any pending migrations
}

// Configure the HTTP request pipeline
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// Weather forecast endpoint
var summaries = new[] { "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching" };

app.MapGet("/weatherforecast", () =>
{
    var forecast = Enumerable.Range(1, 5).Select(index =>
            new WeatherForecast(DateOnly.FromDateTime(DateTime.Now.AddDays(index)), Random.Shared.Next(-20, 55), summaries[Random.Shared.Next(summaries.Length)])).ToArray();
    return forecast;
}).WithName("GetWeatherForecast").WithOpenApi();

app.UseRouting();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers(); 
});

app.Run();

record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}
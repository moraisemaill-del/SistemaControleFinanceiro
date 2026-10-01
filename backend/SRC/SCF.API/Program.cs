using Microsoft.EntityFrameworkCore;
using SCF.Infrastructure.Data;

var builder = WebApplication.CreateBuilder(args);

// ========================================
// SERVIÇOS
// ========================================

builder.Services.AddControllers();

builder.Services.AddOpenApi();


// ========================================
// CORS
// Permite que o frontend HTML converse
// com a API local
// ========================================

builder.Services.AddCors(options =>
{
    options.AddPolicy("Frontend", policy =>
    {
        policy
            .AllowAnyOrigin()
            .AllowAnyHeader()
            .AllowAnyMethod();
    });
});


// ========================================
// BANCO DE DADOS
// ========================================

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("DefaultConnection")
    )
);


var app = builder.Build();


// ========================================
// PIPELINE HTTP
// ========================================

// CORS
app.UseCors("Frontend");


// Durante o desenvolvimento local,
// não vamos redirecionar HTTP para HTTPS.
// Isso evita problemas com localhost:5039.
//
// app.UseHttpsRedirection();


// ========================================
// OPENAPI
// ========================================

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}


// ========================================
// CONTROLLERS
// ========================================

app.MapControllers();


// ========================================
// ENDPOINT DE TESTE
// ========================================

var summaries = new[]
{
    "Freezing",
    "Bracing",
    "Chilly",
    "Cool",
    "Mild",
    "Warm",
    "Balmy",
    "Hot",
    "Sweltering",
    "Scorching"
};

app.MapGet("/weatherforecast", () =>
{
    var forecast = Enumerable
        .Range(1, 5)
        .Select(index => new WeatherForecast(
            DateOnly.FromDateTime(
                DateTime.Now.AddDays(index)
            ),
            Random.Shared.Next(-20, 55),
            summaries[
                Random.Shared.Next(
                    summaries.Length
                )
            ]
        ))
        .ToArray();

    return forecast;
})
.WithName("GetWeatherForecast");


app.Run();


// ========================================
// WEATHER FORECAST
// ========================================

record WeatherForecast(
    DateOnly Date,
    int TemperatureC,
    string? Summary)
{
    public int TemperatureF =>
        32 + (int)(TemperatureC / 0.5556);
}
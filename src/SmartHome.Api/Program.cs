using Microsoft.EntityFrameworkCore;
using SmartHome.Api.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<SmartHomeDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("Default")));

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapGet("/health", () => Results.Ok(new { status = "healthy" }))
   .WithName("HealthCheck")
   .WithOpenApi();

// TODO: Add the device registration endpoint and enforce the subscription plan limits.
// Suggested route: POST /api/smart-homes/{smartHomeId:guid}/devices
// Suggested request fields: accountId, name, type.
// Keep business rules out of the HTTP handler where practical.

app.Run();

public partial class Program { }

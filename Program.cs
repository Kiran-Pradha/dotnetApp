using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Hosting;
using System;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Use 0.0.0.0 to allow external access (e.g., Docker, Render, etc.)
var port = Environment.GetEnvironmentVariable("PORT") ?? "5000";
app.Urls.Add($"http://0.0.0.0:{port}");

app.MapGet("/", () => "Hello from .NET 8 minimal web app!");

app.Run();

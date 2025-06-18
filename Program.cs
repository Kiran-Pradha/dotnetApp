using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Hosting;
using System;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

var port = Environment.GetEnvironmentVariable("PORT") ?? "5000";
app.Urls.Add($"http://*:{port}");

app.MapGet("/", () => "Hello from .NET 8 minimal web app!");

app.Run();

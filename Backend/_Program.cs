using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using CreditCardValidatorAPI.Services;
using System.Net;
using FluentValidation;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddScoped<ICardValidationService, CardValidationService>();


builder.Services.AddControllers();


builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(builder =>
    {
        builder.WithOrigins("https://localhost:3000") 
               .AllowAnyHeader()
               .AllowAnyMethod();
    });
});


var certPath = "C:/Users/USER/Downloads/localhost.pfx";
var certPassword = "#S20000412c";


Console.WriteLine($"CERTIFICATE_PATH: {certPath}");
Console.WriteLine($"CERTIFICATE_PASSWORD: {certPassword}");

if (string.IsNullOrEmpty(certPath) || string.IsNullOrEmpty(certPassword))
{
    throw new ArgumentNullException("CERTIFICATE_PATH and CERTIFICATE_PASSWORD must be set.");
}


builder.WebHost.ConfigureKestrel(options =>
{
    options.Listen(IPAddress.Any, 5001, listenOptions =>
    {
        listenOptions.UseHttps(certPath, certPassword);
    });
});

var app = builder.Build();


app.UseStaticFiles();


app.UseRouting();


app.UseCors();


app.MapGet("/", async context =>
{
    context.Response.ContentType = "text/html";
    await context.Response.SendFileAsync("wwwroot/welcome.html");
});

app.Run();
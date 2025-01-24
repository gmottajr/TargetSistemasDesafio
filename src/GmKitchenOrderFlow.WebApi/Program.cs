using Microsoft.OpenApi.Models;
using GmKitchenOrderFlow.IoC;
namespace GmKitchenOrderFlow.WebApi;

public static class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.DbContextDiRegistration(builder.Configuration);
        builder.Services.AddApplicationServices();
        builder.Services.DataRepositoriesDiRegistration();
        builder.Services.AddConfigurationSettings(builder.Configuration);

        // Add services to the container
        builder.Services.AddControllers();

        builder.Services.AddSwaggerGen(c => {
            c.SwaggerDoc("v1", new OpenApiInfo { 
                Title = "GmKitchenOrderFlow - WebApi", 
                Version = "v1",
                Description = "GmKitchenOrderFlow - WebApi",
                Contact = new OpenApiContact {
                    Name = "Gerson Jr",
                    Email = "contact@gmkitchenorderflow.com",
                    Url = new Uri("https://www.gmkitchenorderflow.com")
                }
                });
        });

        var app = builder.Build();

        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI(c => {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "GmKitchenOrderFlow - WebApi");
                c.RoutePrefix = string.Empty;
            });
        }

        // Configure the HTTP request pipeline
        app.UseRouting();
        app.UseAuthorization();
        app.MapControllers();

        app.Run();
    }
}

using GmKitchenOrderFlow.Application;
using GmKitchenOrderFlow.Application.Services;
using GmKitchenOrderFlow.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace GmKitchenOrderFlow.IoC;

public static class IoCRegisterDiServicesHandler
{
// Register In-Memory Database
        public static IServiceCollection DbContextDiRegistration(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<DbContextKitchen>(options =>
                options.UseInMemoryDatabase("GmKitchenOrderFlowDb")
                .LogTo(Console.WriteLine, LogLevel.Information));
            return services;
        }

        // Register Application Services
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IKitchenAreaAppService, KitchenAreaAppService>();
            services.AddScoped<IMenuItemMealAppService, MenuItemMealAppService>();
            services.AddScoped<IOrderAppService, OrderAppService>();
            services.AddScoped<IQueueAppService, QueueAppService>();
            return services;
        }

        // Register Repositories
        public static IServiceCollection DataRepositoriesDiRegistration(this IServiceCollection services)
        {
            services.AddScoped<IKitchenAreaRepository, KitchenAreaRepository>();
            services.AddScoped<IMenuItemMealRepository, MenuItemMealRepository>();
            services.AddScoped<IOrderRepository, OrderRepository>();
            services.AddScoped<IQueueRepository, QueueRepository>();
            return services;
        }

        // Register Configuration from appsettings.json and user-secrets.json
        public static IServiceCollection AddConfigurationSettings(this IServiceCollection services, IConfiguration configuration)
        {
            //services.Configure<AppSettings>(configuration.GetSection("AppSettings"));
            return services;
        }
}

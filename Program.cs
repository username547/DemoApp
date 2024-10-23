using DemoApp.Data;
using DemoApp.Pages;
using DemoApp.Repository;
using DemoApp.Service;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace DemoApp
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);
            var serviceProvider = serviceCollection.BuildServiceProvider();
            Application.Run(serviceProvider.GetRequiredService<MainForm>());
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<AppDbContext>(options =>
            {
                options.UseNpgsql("Server=localhost;Port=5432;Database=demo;Username=admin;Password=admin");
            });
            services.AddSingleton<IAuthService, AuthService>();
            services.AddScoped<IServiceRepo, ServiceRepo>();
            services.AddScoped<IClientRepo, ClientRepo>();
            services.AddScoped<IEmployeeRepo, EmployeeRepo>();
            services.AddScoped<IDeviceRepo, DeviceRepo>();
            services.AddScoped<IStatusUpdateRepo, StatusUpdateRepo>();
            services.AddScoped<IStatusRepo, StatusRepo>();
            services.AddScoped<ICommentRepo, CommentRepo>();
            services.AddScoped<MainForm>();
            services.AddTransient<LoginPage>();
            services.AddTransient<ServicePage>();
            services.AddTransient<ListServicePage>();
            services.AddTransient<CreateServicePage>();
            services.AddTransient<UpdateServicePage>();
            services.AddTransient<CreateCommentPage>();
        }
    }
}
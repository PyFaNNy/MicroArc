using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OrderMicroService.Application.Interfaces;

namespace OrderMicroService.Persistence
{
    public static class DependenciesBootstrapper
    {
        public static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<OrderDbContext>(options =>
            {
                options.UseSqlServer(
                    configuration.GetValue<string>("MSSQL_URL"),
                    b => b.MigrationsAssembly(typeof(OrderDbContext).Assembly.FullName));

                options.EnableDetailedErrors();
                options.EnableSensitiveDataLogging();
            });
            services.AddScoped<IOrderDbContext>(provider => provider.GetService<OrderDbContext>());

            return services;
        }
    }
}

using BasketMicroService.Application.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BasketMicroService.Persistence
{
    public static class DependenciesBootstrapper
    {
        public static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<BasketDbContext>(options =>
            {
                options.UseSqlServer(
                    configuration.GetValue<string>("MSSQL_URL"),
                    b => b.MigrationsAssembly(typeof(BasketDbContext).Assembly.FullName));

                options.EnableDetailedErrors();
                options.EnableSensitiveDataLogging();
            });
            services.AddScoped<IBasketDbContext>(provider => provider.GetService<BasketDbContext>());

            return services;
        }
    }
}

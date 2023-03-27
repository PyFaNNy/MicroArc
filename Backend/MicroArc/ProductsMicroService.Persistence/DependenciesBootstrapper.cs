using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ProductsMicroService.Application.Interfaces;

namespace ProductsMicroService.Persistence
{
    public static class DependenciesBootstrapper
    {
        public static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ProductDbContext>(options =>
            {
                options.UseSqlServer(
                    configuration.GetValue<string>("MSSQL_URL"),
                    b => b.MigrationsAssembly(typeof(ProductDbContext).Assembly.FullName));

                options.EnableDetailedErrors();
                options.EnableSensitiveDataLogging();
            });
            services.AddScoped<IProductDbContext>(provider => provider.GetService<ProductDbContext>());

            return services;
        }
    }
}

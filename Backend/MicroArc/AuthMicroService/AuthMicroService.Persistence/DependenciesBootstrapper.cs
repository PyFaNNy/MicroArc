using AuthMicroService.Application.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AuthMicroService.Persistence
{
    public static class DependenciesBootstrapper
    {
        public static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AuthDbContext>(options =>
            {
                options.UseSqlServer(
                    configuration.GetValue<string>("MSSQL_URL"),
                    b => b.MigrationsAssembly(typeof(AuthDbContext).Assembly.FullName));

                options.EnableDetailedErrors();
                options.EnableSensitiveDataLogging();
            });
            services.AddScoped<IAuthDbContext>(provider => provider.GetService<AuthDbContext>());

            return services;
        }
    }
}

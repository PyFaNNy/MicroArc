using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ProductsMicroService.Application.Interfaces;
using ProductsMicroService.Application.Services;

namespace ProductsMicroService.Application
{
    public static class DependenciesBootstrapper
    {
        public static IServiceCollection AddApplication(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient<IProductService, ProductService>();
            services.AddTransient<ICategoryService, CategoryService>();

            return services;
        }
    }
}

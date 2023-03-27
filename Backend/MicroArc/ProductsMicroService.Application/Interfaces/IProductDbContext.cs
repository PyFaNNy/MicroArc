using Microsoft.EntityFrameworkCore;
using ProductsMicroService.Domain;

namespace ProductsMicroService.Application.Interfaces
{
    public interface IProductDbContext
    {
        DbSet<Product> Products
        {
            get;
            set;
        }

        DbSet<Category> Categories
        {
            get;
            set;
        }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);

        int SaveChanges();
    }
}

using Microsoft.EntityFrameworkCore;
using ProductsMicroService.Application.Interfaces;
using ProductsMicroService.Domain;

namespace ProductsMicroService.Persistence
{
    public class ProductDbContext : DbContext, IProductDbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        public ProductDbContext(DbContextOptions<ProductDbContext> dbContextOptions) : base(dbContextOptions)
        {
        }

        public override int SaveChanges()
        {
            var result = base.SaveChanges();

            return result;
        }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            var result = await base.SaveChangesAsync(cancellationToken);

            return result;
        }
    }
}

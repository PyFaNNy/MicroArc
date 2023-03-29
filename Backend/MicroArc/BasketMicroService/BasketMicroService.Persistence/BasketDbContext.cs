using BasketMicroService.Application.Interfaces;
using BasketMicroService.Domain;
using Microsoft.EntityFrameworkCore;

namespace BasketMicroService.Persistence
{
    public class BasketDbContext : DbContext, IBasketDbContext
    {
        public DbSet<Basket> Baskets { get; set; }
        public DbSet<BasketItem> BasketItems { get; set; }
        public DbSet<Product> Products { get; set; }

        public BasketDbContext(DbContextOptions<BasketDbContext> dbContextOptions) : base(dbContextOptions)
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

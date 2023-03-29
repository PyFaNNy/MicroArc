using Microsoft.EntityFrameworkCore;
using OrderMicroService.Application.Interfaces;
using OrderMicroService.Domain;

namespace OrderMicroService.Persistence
{
    public class OrderDbContext : DbContext, IOrderDbContext
    {
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderLine> OrderLines { get; set; }
        public DbSet<Product> Products { get; set; }

        public OrderDbContext(DbContextOptions<OrderDbContext> dbContextOptions) : base(dbContextOptions)
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

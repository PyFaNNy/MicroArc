using BasketMicroService.Domain;
using Microsoft.EntityFrameworkCore;

namespace BasketMicroService.Application.Interfaces
{
    public interface IBasketDbContext
    { 
        DbSet<Basket> Baskets { get; set; }
        DbSet<BasketItem> BasketItems { get; set; }
        DbSet<Product> Products { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);

        int SaveChanges();
    }
}

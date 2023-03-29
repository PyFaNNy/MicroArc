using Microsoft.EntityFrameworkCore;
using OrderMicroService.Domain;

namespace OrderMicroService.Application.Interfaces;

public interface IOrderDbContext
{
    public DbSet<Order> Orders { get; set; }
    public DbSet<OrderLine> OrderLines { get; set; }
    public DbSet<Product> Products { get; set; }
}
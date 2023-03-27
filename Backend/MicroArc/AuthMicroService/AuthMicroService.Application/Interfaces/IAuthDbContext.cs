using AuthMicroService.Domain;
using Microsoft.EntityFrameworkCore;

namespace AuthMicroService.Application.Interfaces
{
    public interface IAuthDbContext
    {
        DbSet<User> Products
        {
            get;
            set;
        }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
        int SaveChanges();
    }
}

using AuthMicroService.Application.Interfaces;
using AuthMicroService.Domain;
using Microsoft.EntityFrameworkCore;

namespace AuthMicroService.Persistence
{
    public class AuthDbContext : DbContext, IAuthDbContext
    {
        public DbSet<User> Products { get; set; }

        public AuthDbContext(DbContextOptions<AuthDbContext> dbContextOptions) : base(dbContextOptions)
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

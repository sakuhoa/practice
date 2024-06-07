using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;

namespace practice.Models
{
    public class UserContext : DbContext
    {
        public UserContext(DbContextOptions<UserContext> options)
        : base(options)
        {
        }

        public DbSet<User> Users { get; set; } = null!;
    }
}

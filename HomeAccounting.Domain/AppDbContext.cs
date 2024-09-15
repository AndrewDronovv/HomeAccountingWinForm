using HomeAccounting.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace HomeAccounting.Domain
{
    public class AppDbContext : DbContext
    {
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<User> Users { get; set; }

        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}

using Microsoft.EntityFrameworkCore;

namespace ViewTree.Models
{
    internal class UserContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Database=SoftWEngNew;Username=postgres;Password=123654;Include Error Detail=true");
        }
    }
}

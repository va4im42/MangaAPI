using Microsoft.EntityFrameworkCore;

namespace Backend.ORM
{
    public class ApplicationContext : DbContext
    {
        public DbSet<User> Users { get; set; } = null!;
        
        public ApplicationContext() 
        {
            //Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=postgres;Username=mangapguser;Password=hnunrsz8k");
        }
    }
}

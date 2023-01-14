using BasicBlogMVC.Models.Entity;
using Microsoft.EntityFrameworkCore;

namespace BasicBlogMVC.Models.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Article> Articles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>().HasData(new User(1, "sego", "1234"));
            modelBuilder.Entity<Article>().Property(x => x.CreatedTime).HasDefaultValueSql("getutcdate()");
        }
    }
}

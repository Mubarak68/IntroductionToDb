using Microsoft.EntityFrameworkCore;

namespace IntroductionToDb.Models
{
    public class BlogContext : DbContext
    {
       public DbSet<Blog> blogs {  get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Blog>().HasData(
                new Blog
                {
                    Id = 1,
                    Name = "w3School",
                    Url = "https://www.w3schools.com/"
                }
                );

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=asb.db");
        }
    }
}

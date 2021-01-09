using ForumApp.Models;
using Microsoft.EntityFrameworkCore;

namespace ForumApp.Data
{
    public class ForumDbContext : DbContext
    {
        public ForumDbContext(DbContextOptions<ForumDbContext> options) : base(options) {}

        public DbSet<Category> Categories {get; set;}
        public DbSet<User> Users {get; set;}
        public DbSet<Post> Posts {get; set;}
        public DbSet<Topic> Topics {get; set;}
    }
}
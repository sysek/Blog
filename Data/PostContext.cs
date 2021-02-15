using Microsoft.EntityFrameworkCore;

namespace Blog.Data
{
    public class PostContext : DbContext
    {
        public PostContext(DbContextOptions<PostContext> options) : base(options)
        {
        }

        public DbSet<Blog.Models.Post> Post { get; set; }
    }
}
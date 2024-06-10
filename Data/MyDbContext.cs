using Microsoft.EntityFrameworkCore;

namespace CategoryAPI.Data
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
        }

        public DbSet<Models.Category> Category { get; set; }
    }
}

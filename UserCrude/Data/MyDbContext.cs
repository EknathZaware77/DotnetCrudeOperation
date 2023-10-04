using Microsoft.EntityFrameworkCore;
using UserCrude.Model;

namespace UserCrude.Data
{
    public class MyDbContext:DbContext
    {
        public MyDbContext(DbContextOptions options) : base(options) { }
        public DbSet<User> Users { get; set; }

    }
}

using Microsoft.EntityFrameworkCore;
using StudentCrude.Model;

namespace StudentCrude.Data
{
    public class MyDbContext:DbContext
    {

        public MyDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Student> Students { get; set; }
    }
}

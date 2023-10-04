using EmplyeeCrude.Model;
using Microsoft.EntityFrameworkCore;

namespace EmplyeeCrude.Data
{
    public class MyDbContext:DbContext
    {
        public MyDbContext(DbContextOptions options):base(options) { }

        public DbSet<Employee> Employees { get; set; }
    }
}

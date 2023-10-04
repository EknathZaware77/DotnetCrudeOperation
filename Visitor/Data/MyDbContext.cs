using Microsoft.EntityFrameworkCore;
using Visitor.Model;

namespace Visitor.Data
{
    public class MyDbContext:DbContext
    {
        public MyDbContext(DbContextOptions options) : base(options)
        { }
        public DbSet<Visit> Visitors { get; set; }

        


    }
}

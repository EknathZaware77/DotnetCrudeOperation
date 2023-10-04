using CrudeApp_02.Model;
using Microsoft.EntityFrameworkCore;

namespace CrudeApp_02.Data
{
    public class MyDBContext:DbContext
    {

       public MyDBContext( DbContextOptions options):base(options){ 
        
        
        
        
        
        
        }


        public DbSet<User> Users { get; set; }

    }
}

using System.ComponentModel.DataAnnotations;

namespace EmplyeeCrude.Model
{
    public class Employee
    {

        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

       
    }
}

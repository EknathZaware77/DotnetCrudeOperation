using System.ComponentModel.DataAnnotations;

namespace Visitor.Model
{
    public class Visit
    {

        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateOnly Date { get; set; }
    }
}

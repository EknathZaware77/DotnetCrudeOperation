using System.ComponentModel.DataAnnotations;

namespace CrudeApp_02.Model
{
    public class User
    {
        [Key]
          public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }
}

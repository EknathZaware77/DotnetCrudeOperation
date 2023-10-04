using Microsoft.AspNetCore.Mvc;
using StudentCrude.Model;
using StudentCrude.Service;

namespace StudentCrude.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentController : Controller
    { private IStudentService StudentService { get; set; }
        public StudentController(IStudentService studentService)
        {
            StudentService = studentService;
        }

        [HttpPost]
        public string PostStudent(Student student)
        { 
        return StudentService.AddStudent(student);
        
        }

        [HttpDelete("{id}")]
        public void DeleteStudent(int id)
        {
            StudentService.Delete(id);

        }

        [HttpPut]
        public void UpdateStudent(Student student)
        {
            StudentService.Update(student);
        }

        [HttpGet("/getbyId")]
        public Student GetStudent(int id)
        {
                return StudentService.GetStudentById(id);
        }

        [HttpGet]
        public List<Student> GetStudents()
        {
            return StudentService.GetStudents();
        }


    }
}

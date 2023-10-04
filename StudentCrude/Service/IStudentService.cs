using StudentCrude.Model;

namespace StudentCrude.Service
{
    public interface IStudentService
    {
     
        public void Update(Student student);
        public void Delete(int id);
        public String AddStudent(Student student);
           
        public List<Student> GetStudents();


        public Student GetStudentById(int id);



    }
}

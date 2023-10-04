using StudentCrude.Data;
using StudentCrude.Model;

namespace StudentCrude.Service
{
    public class StudentService : IStudentService
    {

        private MyDbContext context;

        public StudentService( MyDbContext context) {

            this.context = context;
        }
        String IStudentService.AddStudent(Student student)
        {
            try
            {
                context.Students.Add(student);
                context.SaveChanges();
                return "created succefully";
            }
            catch (Exception ex)
            {
                throw new Exception("Not created");
            }
        }

        void IStudentService.Delete(int id)
        {
            try
            {
                Student st=context.Students.Find(id);
                 context.Students.Remove(st);
                context.SaveChanges();

            }
            catch (Exception ex)
            {
                throw new Exception("id not present");
            }
        }

       
        Student IStudentService.GetStudentById(int id)
        {
            try
            {
                return context.Students.Find(id);

            }
            catch (Exception ex)
            {
                throw new Exception("errorS");
            }
        }

        List<Student> IStudentService.GetStudents()
        {
            try
            {
                return context.Students.ToList();

            }
            catch (Exception ex)
            {
                throw new Exception("error");
            }
        }

        void IStudentService.Update(Student student)
        {
            Student st;
            try
            {
                try
                {
                     st = context.Students.Find(student.Id);
                } catch (Exception ex)
                {
                    throw new Exception("not present");
                }
                st.Name= student.Name;
                st.LastName= student.LastName;
                context.Students.Update(st);
                context.SaveChanges();

            }
            catch (Exception ex)
            {
                throw new Exception(" not updatted");
            }
        }
    }
}

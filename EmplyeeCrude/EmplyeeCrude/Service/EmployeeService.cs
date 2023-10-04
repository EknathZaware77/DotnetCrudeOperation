using EmplyeeCrude.Data;
using EmplyeeCrude.Model;
using System.Configuration;
using System.Reflection.Metadata.Ecma335;

namespace EmplyeeCrude.Service
{
    public class EmployeeService : IEmployeeService
    {

        private MyDbContext _db;
        public EmployeeService(MyDbContext db) {  _db = db; }

       
        string IEmployeeService.AddEmployee(Employee emp)
        {
            try
            {
                _db.Employees.Add(emp);
                _db.SaveChanges();
                return "user Created Succefully";
            }catch (Exception ex)
            {
                throw new Exception("user not created ");
            }
        }

        void IEmployeeService.DeleteEmployee(int id)
        {
            try
            {   Employee emp2= _db.Employees.Find(id);
                _db.Employees.Remove(emp2);
                _db.SaveChanges();

            }
            catch (Exception ex)
            {
                throw new Exception("emplyoee not present ");
            }
        }

        List<Employee> IEmployeeService.GetAll()
        {
            return _db.Employees.ToList();

        }

        Employee IEmployeeService.GetByName(string name)
        {
            try
            {
                Employee emp= _db.Employees.Where(a=>a.Name == name).FirstOrDefault();
                _db.SaveChanges ();
                return emp;
            }
            catch (Exception ex)
            {
                throw new Exception(" name does not exists ");
            }
        }

        Employee IEmployeeService.GetEmployee(int id)
        {
            try
            {
               return _db.Employees.Find(id);
                
            
            }
            catch (Exception ex)
            {
                throw new Exception(" not present  ");
            }
        }

        string IEmployeeService.UpdateEloyee(Employee emp)
        {
            try
            {
                Employee emp1 = _db.Employees.Find(emp.Id);
                emp1.Name = emp.Name;
                emp1.Description = emp.Description;
                _db.SaveChanges();
                return "updated succefully ";

            }
            catch (Exception ex)
            {
                throw new Exception("not present");
            }
        }
    }
}

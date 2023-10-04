using EmplyeeCrude.Model;

namespace EmplyeeCrude.Service
{
    public interface IEmployeeService
    {

        public string AddEmployee(Employee emp);

        public void DeleteEmployee(int id);

        public Employee GetEmployee(int id);
        public string UpdateEloyee(Employee emp);
        public Employee GetByName(string name);
        public List<Employee> GetAll();

    }
}

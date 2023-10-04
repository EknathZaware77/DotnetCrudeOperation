using EmplyeeCrude.Model;
using EmplyeeCrude.Service;
using Microsoft.AspNetCore.Mvc;

namespace EmplyeeCrude.Controllers
{  [ApiController]
    [Route("[controller]")]
    public class EmployeeController : Controller
    {


        public IEmployeeService EmployeeService { get; set; }
        public EmployeeController(IEmployeeService employeeService)
        {
            EmployeeService = employeeService;
        }



        [HttpPost]
         public string PostEmployee(Employee employee)
        {
           return EmployeeService.AddEmployee(employee);

        }
        [HttpPut("update")]
        public void UpdateEmployee(Employee employee)
        {
            EmployeeService.UpdateEloyee(employee);
        }

        [HttpDelete("{id}")]
        public void DeleteEmployee(int id)
        {
            EmployeeService.DeleteEmployee(id);
        }

        [HttpGet("{id}")]
        public Employee GetEmployee(int id)
        {
            return EmployeeService.GetEmployee(id);
        }


        [HttpGet("get")]
        public List<Employee> GetEmployees()
        {
            return  EmployeeService.GetAll();
        }

        [HttpGet("byname/{name}")]
        public Employee GetByName(string name)
        {
            return EmployeeService.GetByName(name);
        }

    }
}

using CrudeApp_02.Model;
using CrudeApp_02.Service;
using Microsoft.AspNetCore.Mvc;

namespace CrudeApp_02.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : Controller
    {


        private IUserService UserService { get; set; }



        public UserController(IUserService userService)
        {
            UserService = userService;
        }

        [HttpGet]
        public List<User> getUser()
        {
            return UserService.GetUsers();

        }

        [HttpGet("getUserById/{id}")]
        public User GetUser(int id) { 
        return  UserService.GetUserById(id);
               }




        [HttpPost]  
        public String PostUser(User user)
        {
            return UserService.AddUser(user);
        }



        [HttpDelete("{id}")]
        public void DeleteUser(int id) {
            UserService.DeleteUser(id);                
             }



        [HttpPut]
        public User PutUser(User user)
        {
            return UserService.UpdateUser(user);
        }

        [HttpGet("{name}")]
        public User GetUserbyName(string name)
        {
            return UserService.GetUserByName(name);
        }





    }
}

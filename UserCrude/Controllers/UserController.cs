using Microsoft.AspNetCore.Mvc;
using UserCrude.Model;
using UserCrude.Service;

namespace UserCrude.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : Controller
    {
        public IUserService UserService { get; set; }
        public UserController( IUserService userService) {
        UserService = userService;
        }



        [HttpPost]
        public void AddUser(User user)
        {

           UserService.AddUser(user);
           }

        [HttpGet("{id}")]
        public User GetUser(int id)
        {
            return UserService.GetUserById(id);
        }
        [HttpGet]
        public List<User> GetUsers()
        {
            return UserService.GetAllUsers();
        }


        [HttpDelete]
        public void DeleteUser(int id)
        {
            UserService.DeleteUser(id);
        }


        [HttpPut]
        public void PutUser(User user)
        {
            UserService.UpdateUser(user);
        }


        [HttpGet("byname/{name}")]
        public User GetUserByName(string name)
        {
            return UserService.GetUserByName(name);
        }




    }
}

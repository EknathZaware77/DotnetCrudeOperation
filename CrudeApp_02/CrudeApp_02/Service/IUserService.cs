using CrudeApp_02.Model;

namespace CrudeApp_02.Service
{
    public interface IUserService
    {
        public string AddUser(User user);
        public List<User> GetUsers();
        public User UpdateUser(User user);
        public void DeleteUser(int id);
        public User GetUserById(int id);
        public User GetUserByName(string name);



    }
}

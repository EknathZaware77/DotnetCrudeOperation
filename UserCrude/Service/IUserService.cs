using UserCrude.Model;

namespace UserCrude.Service
{
    public interface IUserService
    {
        public void AddUser(User user);
        public void UpdateUser(User user);
        public void DeleteUser(int id);
        public User GetUserById(int id);
        public User GetUserByName(string name);
     

        public List<User> GetAllUsers();    

    }
}

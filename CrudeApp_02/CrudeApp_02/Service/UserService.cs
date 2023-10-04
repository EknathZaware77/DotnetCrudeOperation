using CrudeApp_02.Data;
using CrudeApp_02.Model;

namespace CrudeApp_02.Service
{
    public class UserService : IUserService
    {

        private MyDBContext _dbContext;


        public UserService(MyDBContext dbContext)
        {
            _dbContext = dbContext;
        }




        public string AddUser(User user)
        {
            try
            {
                _dbContext.Users.Add(user);
                _dbContext.SaveChanges();
                return "created";
            }
            catch(Exception ex)
            {
                throw new Exception("mnot created error");
            }

        }

        public void DeleteUser(int id)
        {
            try
            {
                User user1 = _dbContext.Users.Find(id);
                _dbContext.Users.Remove(user1);
                _dbContext.SaveChanges();
            } catch(Exception ex)
            {
                throw new Exception("user not found");
            }
        }

        public User GetUserById(int id)
        {
            return _dbContext.Users.Find(id);
        }

        public User GetUserByName(string name)
        {
           return   _dbContext.Users.Where(x => x.Name==name).FirstOrDefault();

        }

        public List<User> GetUsers()
        {
            return _dbContext.Users.ToList();
        }

        public User UpdateUser(User user)
        {
            try
            {
               User user1= _dbContext.Users.Find(user.Id);
                user1.Email= user.Email;
                user1.Name= user.Name;
                _dbContext.Users.Update(user1);
                _dbContext.SaveChanges();
                return user1;
            }
            catch (Exception ex)
            {
                throw new Exception("user not found");
            }

        }
    }
}

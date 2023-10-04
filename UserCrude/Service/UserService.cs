using UserCrude.Data;
using UserCrude.Model;

namespace UserCrude.Service
{
    public class UserService : IUserService
    {
        private MyDbContext _db;
        public UserService(MyDbContext db) {  _db = db; }
        void IUserService.AddUser(User user)
        {
            try
            {
                _db.Users.Add(user);
                _db.SaveChanges();
            }
            catch(Exception ex)
            {
                throw new Exception(" error adding");
            }
        }

        void IUserService.DeleteUser(int id)
        {
            try
            {
               User user1= _db.Users.Find(id);
                if (user1 != null)
                {
                    _db.Users.Remove(user1);
                    _db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("not created");
            }
        }

        List<User> IUserService.GetAllUsers()
        {
            try
            {
                return _db.Users.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception("error");
            }
        }

        User IUserService.GetUserById(int id)
        {
            try
            {
                return _db.Users.Find(id);
            }
            catch (Exception ex)
            {
                throw new Exception();
            }
        }

        User IUserService.GetUserByName(string name)
        {
            try
            {
               return _db.Users.Where(a=>a.Name == name).FirstOrDefault();    
            }
            catch (Exception ex)
            {
                throw new Exception(" not avialable");
            }
        }

        void IUserService.UpdateUser(User user)
        {
            try
            {
                User user1=_db.Users.Find(user.Id);
                if (user1 != null)
                {
                    user1.Name = user.Name;
                    user1.Email = user.Email;
                    _db.Users.Update(user1);
                    _db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Not present ");
            }
        }
    }
}

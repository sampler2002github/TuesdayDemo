using TuesdayDemo.Data.Interface;
using TuesdayDemo.Data.Models;

namespace TuesdayDemo.Data.Repository
{
    public class UsersRepositry : IUser
    {
        private readonly ApplicationDbContext _context;
        public UsersRepositry(ApplicationDbContext context)
        {
            _context=context;
        }
        public bool AddUser(User user)
        {
            try
            {
                _context.Users.Add(user);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool DeleteUser(int Id)
        {
            try
            {
                var user = _context.Users.Find(Id);
                _context.Users.Remove(user);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public List<User> GetAllUsers()
        {
            try
            {
                return _context.Users.ToList();
            }
            catch (Exception)
            {

                return null;
            }
        }

        public User GetUserById(int Id)
        {
            try
            {
                return _context.Users.Find(Id);
            }
            catch (Exception)
            {

                return null;
            }
        }

        public bool UpdateUser(User user)
        {
            try
            {
                _context.Users.Update(user);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}

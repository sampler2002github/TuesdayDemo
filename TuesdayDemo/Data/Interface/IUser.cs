using TuesdayDemo.Data.Models;

namespace TuesdayDemo.Data.Interface
{
    public interface IUser
    {
        bool AddUser(User user);
        bool UpdateUser(User user);
        bool DeleteUser(int Id);
        List<User> GetAllUsers();
        User GetUserById(int Id);
    }
}

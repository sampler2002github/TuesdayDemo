using Microsoft.AspNetCore.Mvc;
using TuesdayDemo.Data.Interface;
using TuesdayDemo.Data.Models;

namespace TuesdayDemo.Controllers
{
    public class UsersController : Controller
    {
        private readonly IUser _user;
        public UsersController(IUser user)
        {
            _user = user;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        [Route("GetAllUsers")]
        public IActionResult GetAllUsers()
        {
         return Ok(_user.GetAllUsers());
        }
        [HttpGet]
        [Route("GetUsersById")]
        public IActionResult GetUsersById(int Id)
        {
            return Ok(_user.GetUserById(Id));
        }
        [HttpPost]
        [Route("AddUser")]
        public IActionResult AddUser(User user)
        {
            return Ok(_user.AddUser(user));
        }
        [HttpPut]
        [Route("UpdateUser")]
        public IActionResult UpdateUser(User user)
        {
            return Ok(_user.UpdateUser(user));
        }
        [HttpDelete]
        [Route("DeleteUser")]
        public IActionResult DeleteUser(int Id)
        {
            return Ok(_user.DeleteUser(Id));
        }
    }
}

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using TuesdayDemo.Data;
using TuesdayDemo.Data.Models;

namespace TuesdayDemo.Controllers
{
    [AllowAnonymous]
    [Route("api/[Controllers]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly IConfiguration _config;
        private readonly ApplicationDbContext _context;
        public LoginController(IConfiguration config, ApplicationDbContext context)
        {
            _config = config;
            _context = context;
        }
        [HttpPost]
        public ActionResult Login(Login login)
        {
            var user = _context.Users.FirstOrDefault(x => x.Email == login.UserId && x.Password == login.Password);
            if (user != null)
            {
                var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
                var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);
                var claims = new[]
                {
                 new Claim(ClaimTypes.NameIdentifier, user.Email), 
                };
                var token = new JwtSecurityToken(
                    issuer: _config["Jwt:Issuer"],
                    audience: _config["Jwt:Audience"],
                    claims: claims,
                    expires: DateTime.Now.AddMinutes(10),
                    signingCredentials: credentials

                    );
                return Ok(new { Token = new JwtSecurityTokenHandler().WriteToken(token) }); 
            } 
            return NotFound("User not found!");
        }
    }
}

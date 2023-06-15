using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using OnlineShop.Shared;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace OnlineShop.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        public static UserModel UserModel = new UserModel();
        private readonly IConfiguration _configuration;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly DataContext _context;


        public AuthController(IConfiguration configuration, DataContext context)
        {

            _configuration = configuration;
            _context = context;
        }

        [HttpPost("register")]
        public ActionResult<UserModel> Register(UserModel request)
        {
            string passwordHash = BCrypt.Net.BCrypt.HashPassword(request.Password);

            UserModel.UserName = request.UserName;
            UserModel.Password = passwordHash;

            if (_context.Users == null)
            {
                return Problem("Entity set 'DataContext.Users'  is null.");
            }
            User user = new Shared.User ();
            user.UserName = request.UserName;
            user.Password = request.Password;
            user.Password = BCrypt.Net.BCrypt.HashPassword(user.Password);
            _context.Users.Add(user);
             _context.SaveChangesAsync();
            //return CreatedAtAction("GetUser", new { id = user.Id }, user);
            return Ok(UserModel);
        }

        [HttpPost("login")]
        public ActionResult<UserModel> Login(UserModel request)
        {
            var x = _context.Users.Where(x => x.UserName == request.UserName).FirstOrDefault();
            if (request.UserName != x.UserName)
            {
                return BadRequest("UserModel not found.");
            }

            if (!BCrypt.Net.BCrypt.Verify(request.Password, x.Password))
            {
                return BadRequest("Wrong password.");
            }

            var token = GenerateToken(request.UserName);

            return Ok(token);
        }

       

        private object GenerateToken(string user)
        {
            Console.WriteLine(user);
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration.GetValue<string>("Jwt:Key")));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var claims = new[]
            {
                new Claim(ClaimTypes.NameIdentifier,user)

            };
            var token = new JwtSecurityToken(_configuration.GetValue<string>("Jwt:Issuer"),
                _configuration.GetValue<string>("Jwt:Audience"),
                claims,
                expires: DateTime.Now.AddMinutes(15),
                signingCredentials: credentials);


            return new JwtSecurityTokenHandler().WriteToken(token);
        }

    }
}

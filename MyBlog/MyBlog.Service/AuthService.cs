using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using MyBlog.Repository.Interfaces;
using MyBlog.Service.Interfaces;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

namespace MyBlog.Service
{
    public class AuthService : IAuthService
    {
        public AuthService(IUserRepository userRepo)
        {
            UserRepo = userRepo;
        }

        public IUserRepository UserRepo { get; }

        public async Task<bool> SignInAsync(string username, string password, HttpContext httpContext)
        {
            var user = UserRepo.GetByUsername(username);
            if (user != null && user.Password == password)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.NameIdentifier, user.Username),
                    new Claim(ClaimTypes.Name, user.Username),
                    new Claim("Id", user.Id.ToString()),
                };
                var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                var principal = new ClaimsPrincipal(identity);

                await httpContext.SignInAsync(principal);
                return true;
            }
            return false;
        }
    }
}

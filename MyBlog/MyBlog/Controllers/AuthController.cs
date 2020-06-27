using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MyBlog.Service.Interfaces;
using MyBlog.ViewModels.AuthModels;
using System.Threading.Tasks;

namespace MyBlog.Controllers
{
    public class AuthController : Controller
    {
        private readonly IAuthService authService;
        private readonly IMapper mapper;

        public AuthController(IAuthService authService, IMapper mapper)
        {
            this.authService = authService;
            this.mapper = mapper;
        }

        public IActionResult SignIn()
        {
            ViewBag.header = "Enter username and password";
            var model = new SignInModel();
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> SignIn(SignInModel model)
        {
            ViewBag.header = "Enter username and password";
            var user = mapper.Map<MyBlog.Data.User>(model);
            if (ModelState.IsValid)
            {
                var IsUserValid = await authService.SignInAsync(user.Username, user.Password, HttpContext);
                if (IsUserValid)
                {
                    return RedirectToAction("HomePage", "Post");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Incorrect username or password");
                    return View(user);
                }
            }
            return View(model);
        }
    }
}
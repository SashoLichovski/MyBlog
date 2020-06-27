using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MyBlog.Service.Interfaces;
using MyBlog.ViewModels.UserModels;

namespace MyBlog.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService userService;
        private readonly IMapper mapper;

        public UserController(IUserService userService, IMapper mapper)
        {
            this.userService = userService;
            this.mapper = mapper;
        }
        public IActionResult Register()
        {
            ViewBag.header = "Enter credentials";
            var model = new RegisterModel();
            return View(model);
        }
        [HttpPost]
        public IActionResult Register(RegisterModel model)
        {
            if (ModelState.IsValid)
            {
                var user = mapper.Map<MyBlog.Data.User>(model);
                bool isValid = userService.RegisterUser(user);
                if (isValid)
                {
                    return RedirectToAction("SignIn", "Auth");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, $"Username {model.Username} already exist.");
                    return View();
                }
            }
            return View(model);
        }
    }
}
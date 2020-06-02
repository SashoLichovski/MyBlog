using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyBlog.Data;
using MyBlog.Service.Interfaces;

namespace MyBlog.Controllers
{
    public class AuthController : Controller
    {
        public IAuthService UserService { get; }
        public AuthController(IAuthService usersService)
        {
            UserService = usersService;
        }

        public IActionResult SignIn()
        {
            ViewBag.header = "Enter username and password";
            return View();
        }
        [HttpPost]
        public IActionResult SignIn(User user)
        {
            ViewBag.header = "Enter username and password";
            if (ModelState.IsValid)
            {
                var IsUserValid = UserService.SignIn(user.Username, user.Password);
                if (IsUserValid)
                {
                    return RedirectToAction("Index", "Post");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Incorrect username or password");
                    return View(user);
                }
            }
            return View(user);
        }
    }
}
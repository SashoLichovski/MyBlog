using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyBlog.Models;
using MyBlog.Service;

namespace MyBlog.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.header = "Enjoy the latest skate news and videos";
            var service = new PostService();
            return View(service.GetAll());
        }


        public IActionResult AboutUs()
        {
            ViewBag.header = "About us";
            return View();
        }

        public IActionResult StoryDetails(int id)
        {
            ViewBag.header = "Full story";
            var service = new PostService();
            var currentPost = service.GetById(id);
            return View(currentPost);
        }
    }
}

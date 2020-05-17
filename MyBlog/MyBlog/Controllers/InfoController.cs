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
    public class InfoController : Controller
    {
        public IActionResult AboutUs()
        {
            ViewBag.header = "About us";
            return View();
        }
    }
}

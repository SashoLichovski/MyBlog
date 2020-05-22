using Microsoft.AspNetCore.Mvc;

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

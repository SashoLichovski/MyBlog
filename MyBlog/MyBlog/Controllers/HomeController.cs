using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyBlog.Models;

namespace MyBlog.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var posts = new List<Post>();
            var post1 = new Post()
            {
                ImageUrl = "https://scx2.b-cdn.net/gfx/news/hires/2019/2-nature.jpg",
                Title = "Doubles LTD's New Mess Video",
                Description = "The Doubles dudes make a mess in NYC with psycho over-under moves and giant wall bashes. Jet Caputo, Nick Hall, Tony Karr and crew go on a tear while keeping stoke levels at an all-time high. ",
                DatePosted = DateTime.Now
            };
            var post2 = new Post()
            {
                ImageUrl = "https://www.thrashermagazine.com/mediaV2/k2/items/cache/d9ca985dc0a885e4ced2e4e6e549c55b_S_JD.jpg?t=1588957412",
                Title = "DC Shoes: Philly For You",
                Description = "DC pays homage to Philly’s enduring legacy with Kalis footy through the ages and new stuff from Jahmir Brown, Kevin Bilyeu, Brian Panebianco and Justin Adeniran. Sear that 360 flip at Love into your brain.",
                DatePosted = DateTime.Now
            };
            var post3 = new Post()
            {
                ImageUrl = "https://www.thrashermagazine.com/mediaV2/k2/items/cache/65530175545cbc99f5d26d216fe5931c_S_JD.jpg?t=1588963377",
                Title = "Shmatty's COVX - 19 Part",
                Description = "The LA ledge lord dials up combos like a mathematician. Pop, precision and a mean flick are all part of the equation. Check the work... ",
                DatePosted = DateTime.Now
            };
            var post4 = new Post()
            {
                ImageUrl = "https://dailygrind.se/PhotoArchive/2012/20120718_DG_stefan.jpg",
                Title = "Shmatty's COVX - 19 Part",
                Description = "The LA ledge lord dials up combos like a mathematician. Pop, precision and a mean flick are all part of the equation. Check the work... ",
                DatePosted = DateTime.Now
            };
            posts.Add(post1);
            posts.Add(post2);
            posts.Add(post3);
            posts.Add(post4);

            return View(posts);
        }


    }
}

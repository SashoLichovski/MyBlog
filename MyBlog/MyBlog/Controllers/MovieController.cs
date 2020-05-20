using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyBlog.Models;
using MyBlog.Service;
using MyBlog.Service.Interfaces;
using Newtonsoft.Json;

namespace MyBlog.Controllers
{
    public class MovieController : Controller
    {
        public IPostService PostService { get; set; }
        public MovieController(IPostService postService)
        {
            PostService = postService;
        }

        public IActionResult Index()
        {
            ViewBag.header = "Enjoy the latest skate news and videos";
            var postList = PostService.GetAll();
            return View(postList);
        }

        public IActionResult StoryDetails(int id)
        {
            ViewBag.header = "Full story";
            var currentPost = PostService.GetById(id);
            return View(currentPost);
        }

        public IActionResult CreatePost()
        {
            ViewBag.header = "Create new Post";
           var newPost = new Post();
            return View(newPost);
        }
        [HttpPost]
        public IActionResult CreatePost(Post post)
        {
            if (ModelState.IsValid)
            {
            PostService.AddPost(post);
            return Redirect("Index");
            }
            else
            {
                return View(post);
            }
        }
    }
}
using Microsoft.AspNetCore.Mvc;
using MyBlog.Models;
using MyBlog.Service.Interfaces;

namespace MyBlog.Controllers
{
    public class PostController : Controller
    {
        public IPostService PostService { get; set; }
        public PostController(IPostService postService)
        {
            PostService = postService;
        }

        public IActionResult Index(string title, string category)
        {
            ViewBag.header = "X-news Presents";

            if (category == null)
            {
                category = "Skate";
            }
            var postList = PostService.GetAllByCategory(category);

            var searchedPosts = PostService.SearchPost(title);
            if (title != null)
            {
                postList = searchedPosts;
            }
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
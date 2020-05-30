using Microsoft.AspNetCore.Mvc;
using MyBlog.Data;
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

        public IActionResult ManagePosts(string title)
        {
            ViewBag.header = "Manage posts";
            var posts = PostService.GetAll();
            if (title != null)
            {
                var searchedPosts = PostService.SearchPost(title);
                posts = searchedPosts;
            }
            return View(posts);
        }

        public IActionResult DeletePost(int id)
        {
            PostService.RemovePost(id);
            return RedirectToAction("ManagePosts");
        }

        public IActionResult ModifyPost(int id)
        {
            ViewBag.header = "Modify Post";
            var post = PostService.GetById(id);
            return View(post);
        }
        [HttpPost]
        public IActionResult ModifyPost(Post post)
        {
            ViewBag.header = "Modify Post";
            PostService.UpdatePost(post);
            return RedirectToAction("ManagePosts");
        }
    }
}
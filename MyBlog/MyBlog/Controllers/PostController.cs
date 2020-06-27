using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MyBlog.Service.Interfaces;
using MyBlog.ViewModels.PostModels;
using System.Collections.Generic;

namespace MyBlog.Controllers
{
    public class PostController : Controller
    {
        private readonly IMapper mapper;

        public IPostService PostService { get; set; }
        public PostController(IPostService postService, IMapper mapper)
        {
            PostService = postService;
            this.mapper = mapper;
        }

        public IActionResult HomePage(string title, string category)
        {
            ViewBag.header = "X-news Presents";

            if (category == null)
            {
                category = "Skate";
            }
            var postList = PostService.GetAllByCategory(category);

            var convertedList = new List<HomePageModel>();
            foreach (var post in postList)
            {
                convertedList.Add(mapper.Map<HomePageModel>(post));
            }

            if (title != null)
            {
                var searchedPosts = PostService.SearchPost(title);
                var convertedSearch = new List<HomePageModel>();
                foreach (var post in searchedPosts)
                {
                    convertedSearch.Add(mapper.Map<HomePageModel>(post));
                }
                convertedList = convertedSearch;
            }


            return View(convertedList);
        }

        public IActionResult StoryDetails(int id)
        {
            ViewBag.header = "Full story";
            var currentPost = PostService.GetById(id);
            var model = mapper.Map<PostDetailsModel>(currentPost);
            return View(model);
        }

        public IActionResult CreatePost()
        {
            ViewBag.header = "Create new Post";
            var newPostModel = new CreatePostModel();
            return View(newPostModel);
        }
        [HttpPost]
        public IActionResult CreatePost(CreatePostModel model)
        {
            if (ModelState.IsValid)
            {
                var post = mapper.Map<MyBlog.Data.Post>(model);
                PostService.AddPost(post);
                return Redirect("Index");
            }
            else
            {
                return View(model);
            }
        }

        public IActionResult ManagePosts(string title)
        {
            ViewBag.header = "Manage posts";
            var posts = PostService.GetAll();

            var convertedList = new List<ManagePostModel>();
            posts.ForEach(x => convertedList.Add(mapper.Map<ManagePostModel>(x)));
            if (title != null)
            {
                var searchedPosts = PostService.SearchPost(title);
                posts = searchedPosts;
            }
            return View(convertedList);
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
        public IActionResult ModifyPost(ModifyPostModel model)
        {
            ViewBag.header = "Modify Post";
            var post = mapper.Map<MyBlog.Data.Post>(model);
            PostService.UpdatePost(post);
            return RedirectToAction("ManagePosts");
        }
    }
}
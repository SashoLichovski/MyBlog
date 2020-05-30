using MyBlog.Data;
using MyBlog.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace MyBlog.Repository
{
    public class PostRepository : IPostRepository
    {

        public MyBlogContext Context { get; set; }
        public PostRepository(MyBlogContext context)
        {
            Context = context;
        }
        public void Add(Post post)
        {
            Context.Posts.Add(post);
            Context.SaveChanges();
        }

        public List<Post> GetAllByCategory(string category)
        {
            return Context.Posts.Where(x => x.Category == category).ToList();
        }

        public Post GetById(int id)
        {
            return Context.Posts.FirstOrDefault(x => x.Id == id);
        }

        public List<Post> SearchPost(string search)
        {
            return Context.Posts.Where(x => x.Title == search).ToList();
        }

        public List<Post> GetAll()
        {
            return Context.Posts.ToList();
        }

        public void RemovePost(int id)
        {
            var post = new Post()
            {
                Id = id
            };
            Context.Posts.Remove(post);
            Context.SaveChanges();
        }

        public void UpdatePost(Post post)
        {
            Context.Posts.Update(post);
            Context.SaveChanges();
        }
    }
}

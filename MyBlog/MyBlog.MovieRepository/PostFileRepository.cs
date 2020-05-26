using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using MyBlog.Models;
using Newtonsoft.Json;

namespace MyBlog.Repository.Interfaces
{
    public class PostFileRepository : IPostRepository
    {
        public List<Post> Posts { get; set; }
        public PostFileRepository()
        {
            var jsonString = File.ReadAllText("file.txt");
            var output = JsonConvert.DeserializeObject<List<Post>>(jsonString);

            Posts = output;
        }
        public List<Post> GetAll()
        {
            return Posts;
        }
        public void Add(Post post)
        {
            Posts.Add(post);
            var serialized = JsonConvert.SerializeObject(Posts);
            File.WriteAllText("file.txt", serialized);
        }

        public List<Post> GetAllByCategory(string category)
        {
            var byCategory = new List<Post>();
            foreach (var post in Posts)
            {
                if (post.Category == category)
                {
                    byCategory.Add(post);
                }
            }
            return byCategory;
        }

        public Post GetById(int id)
        {
            return Posts.FirstOrDefault(x => x.Id == id);
        }

        public List<Post> SearchPost(string search)
        {
            var searchResult = new List<Post>();
            if (search != null)
            {
                foreach (var post in Posts)
                {
                    if (post.Title.Contains(search))
                    {
                        searchResult.Add(post);
                    }
                }
            }
            return searchResult;
        }
    }
}

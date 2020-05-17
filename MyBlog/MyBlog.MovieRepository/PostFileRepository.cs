using MyBlog.Models;
using MyBlog.Repository.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace MyBlog.Repository
{
    public class PostFileRepository : IPostRepository
    {
        public List<Post> Posts { get; set; }
        public PostFileRepository()
        {
            var jsonString = File.ReadAllText("file.txt");
            var outPut = JsonConvert.DeserializeObject<List<Post>>(jsonString);
            Posts = outPut;
        }

        public void Save()
        {
            var s = JsonConvert.SerializeObject(Posts);
            File.WriteAllText("file.txt", s);
        }
        public void Add(Post post)
        {
            Posts.Add(post);
        }
        public List<Post> GetAll()
        {
            return Posts;
        }

        public Post GetById(int id)
        {
            return Posts.FirstOrDefault(x => x.Id == id);
        }
    }
}

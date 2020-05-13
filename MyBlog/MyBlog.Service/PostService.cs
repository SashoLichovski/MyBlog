using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyBlog.Models;
using MyBlog.Repository;

namespace MyBlog.Service
{
    public class PostService
    {
        public PostRepository PostRepository { get; set; }
        public PostService()
        {
            PostRepository = new PostRepository();
        }
        public List<Post> GetAll()
        {
            return PostRepository.GetAll();
        }

        public Post GetById(int id)
        {
            return PostRepository.Posts.FirstOrDefault(x => x.Id == id);
        }
    }
}

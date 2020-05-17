using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyBlog.Models;
using MyBlog.Repository;
using MyBlog.Repository.Interfaces;
using MyBlog.Service.Interfaces;

namespace MyBlog.Service
{
    public class PostService : IPostService
    {
        public IPostRepository PostRepository { get; set; }
        public PostService(IPostRepository postRepo)
        {
            PostRepository = postRepo;
        }
        public void Save()
        {
            PostRepository.Save();
        }
        public void Add(Post post)
        {
            PostRepository.Add(post);
        }
        public List<Post> GetAll()
        {
            return PostRepository.GetAll();
        }

        public Post GetById(int id)
        {
            return PostRepository.GetById(id);
        }
    }
}

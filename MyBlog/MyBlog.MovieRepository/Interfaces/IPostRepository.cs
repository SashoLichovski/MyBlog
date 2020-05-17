using MyBlog.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyBlog.Repository.Interfaces
{
    public interface IPostRepository
    {
        void Save();
        void Add(Post post);
        List<Post> GetAll();
        Post GetById(int id);
    }
}

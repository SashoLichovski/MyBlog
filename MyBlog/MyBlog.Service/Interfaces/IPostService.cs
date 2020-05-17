using MyBlog.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyBlog.Service.Interfaces
{
    public interface IPostService
    {
        void Save();
        void Add(Post post);
        Post GetById(int id);
        List<Post> GetAll();
    }
}

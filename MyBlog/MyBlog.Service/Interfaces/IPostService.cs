using MyBlog.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyBlog.Service.Interfaces
{
    public interface IPostService
    {
        Post GetById(int id);
        List<Post> GetAll();
        void AddPost(Post post);
    }
}

using MyBlog.Models;
using System.Collections.Generic;

namespace MyBlog.Service.Interfaces
{
    public interface IPostService
    {
        Post GetById(int id);
        List<Post> GetAll(string category);
        void AddPost(Post post);
        List<Post> SearchPost(string search); 
    }
}

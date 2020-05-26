using MyBlog.Models;
using System.Collections.Generic;

namespace MyBlog.Repository.Interfaces
{
    public interface IPostRepository
    {
        void Add(Post post);
        List<Post> GetAllByCategory(string category);
        Post GetById(int id);
        List<Post> SearchPost(string search);
    }
}

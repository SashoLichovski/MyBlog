using MyBlog.Data;
using System.Collections.Generic;

namespace MyBlog.Service.Interfaces
{
    public interface IPostService
    {
        Post GetById(int id);
        List<Post> GetAllByCategory(string category);
        void AddPost(Post post);
        List<Post> SearchPost(string search);
        List<Post> GetAll();
        void RemovePost(int id);
        void UpdatePost(Post post);
    }
}

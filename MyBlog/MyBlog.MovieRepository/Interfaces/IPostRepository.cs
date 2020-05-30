using MyBlog.Data;
using System.Collections.Generic;

namespace MyBlog.Repository.Interfaces
{
    public interface IPostRepository
    {
        void Add(Post post);
        List<Post> GetAllByCategory(string category);
        Post GetById(int id);
        List<Post> SearchPost(string search);
        List<Post> GetAll();
        void RemovePost(int id);
        void UpdatePost(Post post);
    }
}

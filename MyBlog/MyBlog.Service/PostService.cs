using System.Collections.Generic;
using MyBlog.Data;
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
        public void AddPost(Post post)
        {
            PostRepository.Add(post);
        }
        public List<Post> GetAllByCategory(string category)
        {
            return PostRepository.GetAllByCategory(category);
        }

        public Post GetById(int id)
        {
            return PostRepository.GetById(id);
        }

        public List<Post> SearchPost(string search)
        {
            return PostRepository.SearchPost(search);
        }

        public List<Post> GetAll()
        {
            return PostRepository.GetAll();
        }

        public void RemovePost(int id)
        {
            PostRepository.RemovePost(id);
        }

        public void UpdatePost(Post post)
        {
            PostRepository.UpdatePost(post);
        }
    }
}

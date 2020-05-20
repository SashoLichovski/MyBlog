using MyBlog.Models;
using MyBlog.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace MyBlog.Repository
{
    public class PostSqlRepository : IPostRepository
    {
        public void Add(Post post)
        {
            throw new NotImplementedException();
        }

        public List<Post> GetAll()
        {
            var allPosts = new List<Post>();
            using (var cnn = new SqlConnection("Data Source = .\\sqlexpress; Initial Catalog = MyBlog; Integrated Security = true;"))
            {
                cnn.Open();
                var cmd = new SqlCommand("SELECT * FROM Posts", cnn);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    var post = new Post()
                    {
                        Id = reader.GetInt32(0),
                        ImageUrl = reader.GetString(1),
                        Title = reader.GetString(2),
                        Description = reader.GetString(3),
                        VideoUrl = reader.GetString(4),
                        DatePosted = reader.GetDateTime(5)
                    };
                    allPosts.Add(post);
                }
            }
            return allPosts;
        }

        public Post GetById(int id)
        {
            Post newPost = null;

            using (var cnn = new SqlConnection("Data Source = .\\sqlexpress; Initial Catalog = MyBlog; Integrated Security = true"))
            {
                cnn.Open();

                var cmd = new SqlCommand($"SELECT * FROM Posts WHERE Id = {id}", cnn);

                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    newPost = new Post()
                    {
                        Id = reader.GetInt32(0),
                        ImageUrl = reader.GetString(1),
                        Title = reader.GetString(2),
                        Description = reader.GetString(3),
                        VideoUrl = reader.GetString(4),
                        DatePosted = reader.GetDateTime(5)
                    };
                }
            }
            return newPost;
        }

        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}

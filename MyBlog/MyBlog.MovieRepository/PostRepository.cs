using MyBlog.Models;
using MyBlog.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace MyBlog.Repository
{
    public class PostRepository : IPostRepository
    {
        
        public void Add(Post post)
        {
            using (var cnn = new SqlConnection("Data Source = .\\sqlexpress; Initial Catalog = MyBlog; Integrated Security = true;"))
            {
                cnn.Open();

                var query = @"insert into Posts (ImageUrl, Title, Description, VideoUrl, DatePosted, Category)
                                values(@ImageUrl, @Title, @Description, @VideoUrl, @DatePosted, @Category)";
                var cmd = new SqlCommand(query, cnn);
                cmd.Parameters.AddWithValue("@ImageUrl", post.ImageUrl);
                cmd.Parameters.AddWithValue("@Title", post.Title);
                cmd.Parameters.AddWithValue("@Description", post.Description);
                cmd.Parameters.AddWithValue("@VideoUrl", post.VideoUrl);
                cmd.Parameters.AddWithValue("@DatePosted", DateTime.Now);
                cmd.Parameters.AddWithValue("@Category", post.Category);

                cmd.ExecuteNonQuery();
            }
        }

        public List<Post> GetAllByCategory(string category)
        {
            var allPosts = new List<Post>();
            using (var cnn = new SqlConnection("Data Source = .\\sqlexpress; Initial Catalog = MyBlog; Integrated Security = true;"))
            {
                cnn.Open();
                var query = "SELECT * FROM Posts where Category = @Category";
                var cmd = new SqlCommand(query, cnn);
                cmd.Parameters.AddWithValue("@Category", category);
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
                        DatePosted = reader.GetDateTime(5),
                        Category = reader.GetString(6)
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
                        DatePosted = reader.GetDateTime(5),
                        Category = reader.GetString(6)
                    };
                }
            }
            return newPost;
        }

        public List<Post> SearchPost(string search)
        {
            var searchedPosts = new List<Post>();

            using (var cnn = new SqlConnection("Data Source = .\\sqlexpress; Initial Catalog = MyBlog; Integrated Security = true"))
            {
                cnn.Open();

                var cmd = new SqlCommand($"SELECT * FROM Posts WHERE Title like @Title", cnn);
                cmd.Parameters.AddWithValue("@Title", "%" + search + "%");
                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    var newPost = new Post()
                    {
                        Id = reader.GetInt32(0),
                        ImageUrl = reader.GetString(1),
                        Title = reader.GetString(2),
                        Description = reader.GetString(3),
                        VideoUrl = reader.GetString(4),
                        DatePosted = reader.GetDateTime(5)
                    };
                    searchedPosts.Add(newPost);
                }
            }
            return searchedPosts;

        }
    }
}

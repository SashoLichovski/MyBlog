using MyBlog.Models;
using MyBlog.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace MyBlog.Repository
{
    public class GalleryImageRepository : IGalleryImageRepository
    {
        public List<GalleryImage> GetAll()
        {
            var allImages = new List<GalleryImage>();

            using (var cnn = new SqlConnection("Data Source = .\\sqlexpress; Initial Catalog = MyBlog; Integrated Security = true;"))
            {
                cnn.Open();

                var cmd = new SqlCommand("select * from GalleryImages", cnn);

                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    var image = new GalleryImage()
                    {
                        Id = reader.GetInt32(0),
                        ImageUrl = reader.GetString(1)
                    };
                    allImages.Add(image);
                }
            }
            return allImages;
        }
    }
}

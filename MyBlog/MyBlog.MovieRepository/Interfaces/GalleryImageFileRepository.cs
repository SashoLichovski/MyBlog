using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using MyBlog.Models;
using Newtonsoft.Json;

namespace MyBlog.Repository.Interfaces
{
    public class GalleryImageFileRepository : IGalleryImageRepository
    {
        public List<GalleryImage> Images { get; set; }
        public GalleryImageFileRepository()
        {
            var jsonString = File.ReadAllText("fileImages.txt");
            var output = JsonConvert.DeserializeObject<List<GalleryImage>>(jsonString);

            Images = output;
        }
        public List<GalleryImage> GetAll()
        {
            return Images;
        }
    }
}

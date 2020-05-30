using MyBlog.Data;
using MyBlog.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace MyBlog.Repository
{
    public class GalleryImageRepository : IGalleryImageRepository
    {
        public MyBlogContext Context { get; set; }
        public GalleryImageRepository(MyBlogContext context)
        {
            Context = context;
        }
        public List<GalleryImage> GetAll()
        {
            return Context.GalleryImages.ToList();
        }
    }
}

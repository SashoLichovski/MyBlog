using System;
using System.Collections.Generic;
using System.Text;

namespace MyBlog.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string ImageUrl { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string VideoUrl { get; set; }
        public DateTime DatePosted { get; set; }
    }
}

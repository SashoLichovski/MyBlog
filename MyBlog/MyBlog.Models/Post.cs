using System;
using System.ComponentModel.DataAnnotations;

namespace MyBlog.Models
{
    public class Post
    {
        public int Id { get; set; }
        [Required]
        public string Category { get; set; }
        [Required]
        public string ImageUrl { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string VideoUrl { get; set; }
        public DateTime DatePosted { get; set; }
    }
}

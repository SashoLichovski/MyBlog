using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBlog.ViewModels.PostModels
{
    public class HomePageModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DatePosted { get; set; }
        public string ImageUrl { get; set; }
    }
}

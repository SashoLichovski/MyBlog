using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyBlog.Models;

namespace MyBlog.Repository
{
    public class PostRepository
    {
        public List<Post> Posts { get; set; }
        public PostRepository()
        {
            Posts = new List<Post>();
            var post1 = new Post()
            {
                Id = 0,
                ImageUrl = "https://www.thrashermagazine.com/mediaV2/k2/items/cache/4e8eb752f126f3ef9a323b7848a1a528_M.jpg?t=1588955190",
                Title = "Doubles LTD's New Mess Video",
                Description = "The Doubles dudes make a mess in NYC with psycho over-under moves and giant wall bashes. Jet Caputo, Nick Hall, Tony Karr and crew go on a tear while keeping stoke levels at an all-time high. ",
                DatePosted = DateTime.Now,
                VideoUrl = "hwXQDTDkAeQ"
            };
            var post2 = new Post()
            {
                Id = 1,
                ImageUrl = "https://www.thrashermagazine.com/mediaV2/k2/items/cache/d9ca985dc0a885e4ced2e4e6e549c55b_S_JD.jpg?t=1588957412",
                Title = "DC Shoes: Philly For You",
                Description = "DC pays homage to Philly’s enduring legacy with Kalis footy through the ages and new stuff from Jahmir Brown, Kevin Bilyeu, Brian Panebianco and Justin Adeniran. Sear that 360 flip at Love into your brain.",
                DatePosted = DateTime.Now,
                VideoUrl = "cL2bmXgqVJ4"
            };
            var post3 = new Post()
            {
                Id = 2,
                ImageUrl = "https://www.thrashermagazine.com/mediaV2/k2/items/cache/32498ff9b2f5b3b70333bfa57eccf735_M.jpg?t=1588867306",
                Title = "Hélas Fellas A Cappella Los Angeles Video",
                Description = "Lucas Puig and company leave the LA ledges in rubble—handling nosy neighbors, street bumps and stress, they stack a surplus too big for the double-disc. That switch 360 heelflip will need a few rewinds. World domination.",
                DatePosted = DateTime.Now,
                VideoUrl = "lOttmcVgGWE"
            };
            var post4 = new Post()
            {
                Id = 3,
                ImageUrl = "https://www.thrashermagazine.com/mediaV2/k2/items/cache/c2b7d976401516dcd2ce6c2c6f894861_S_JD.jpg?t=1589219505",
                Title = "Vans EU's Tom's Tales Video",
                Description = "The Vans EU crew beat the bloody hell out of the stone streets while Victor “Doobie” Pellegrin supplies the party stoke and closes the curtains. Trust us, you need this in your life.  ",
                DatePosted = DateTime.Now,
                VideoUrl = "l9I5ODsCeMM"
            };
            Posts.Add(post1);
            Posts.Add(post2);
            Posts.Add(post3);
            Posts.Add(post4);
        }

        public List<Post> GetAll()
        {
            return Posts;
        }

        public Post GetById(int id)
        {
            return Posts.FirstOrDefault(x => x.Id == id);
        }
    }
}

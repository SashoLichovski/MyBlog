using MyBlog.Data;
using MyBlog.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyBlog.Repository
{
    public class UserRepository : IUserRepository
    {
        public MyBlogContext Context { get; }
        public UserRepository(MyBlogContext context)
        {
            Context = context;
        }

        public User GetUserByUsername(string username)
        {
            return Context.Users.FirstOrDefault(x => x.Username == username);
        }
    }
}

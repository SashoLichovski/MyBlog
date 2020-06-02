using MyBlog.Data;
using MyBlog.Repository.Interfaces;
using MyBlog.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyBlog.Service
{
    public class AuthService : IAuthService
    {
        public AuthService(IUserRepository userRepo)
        {
            UserRepo = userRepo;
        }

        public IUserRepository UserRepo { get; }

        public bool SignIn(string username, string password)
        {
            var user = UserRepo.GetUserByUsername(username);
            if (user != null && user.Password == password)
            {
                return true;
            }
            return false;
        }
    }
}

using MyBlog.Data;
using MyBlog.Repository.Interfaces;
using MyBlog.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyBlog.Service
{
    public class UserService : IUserService
    {
        private readonly IUserRepository userRepository;

        public UserService(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public bool RegisterUser(User user)
        {
            var checkUser = userRepository.GetByUsername(user.Username);
            if (checkUser == null)
            {
                userRepository.Add(user);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

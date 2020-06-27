using System;
using System.Collections.Generic;
using System.Text;
using MyBlog.Data;

namespace MyBlog.Service.Interfaces
{
    public interface IUserService
    {
        bool RegisterUser(User user);
    }
}

using MyBlog.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyBlog.Service.Interfaces
{
    public interface IAuthService
    {
        bool SignIn(string username, string password);
    }
}

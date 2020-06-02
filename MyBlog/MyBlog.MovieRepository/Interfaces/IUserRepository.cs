﻿using MyBlog.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyBlog.Repository.Interfaces
{
    public interface IUserRepository
    {
        User GetUserByUsername(string username);
    }
}
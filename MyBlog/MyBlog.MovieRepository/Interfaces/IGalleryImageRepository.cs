﻿using MyBlog.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyBlog.Repository.Interfaces
{
    public interface IGalleryImageRepository
    {
        List<GalleryImage> GetAll();
    }
}

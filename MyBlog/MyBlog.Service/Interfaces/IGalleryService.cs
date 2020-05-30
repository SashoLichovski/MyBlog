using MyBlog.Data;
using System;
using System.Collections.Generic;

namespace MyBlog.Service.Interfaces
{
    public interface IGalleryService
    {
        List<GalleryImage> GetAll();
    }
}

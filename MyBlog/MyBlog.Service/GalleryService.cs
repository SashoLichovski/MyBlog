using MyBlog.Data;
using MyBlog.Repository.Interfaces;
using MyBlog.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyBlog.Service
{
    public class GalleryService : IGalleryService
    {
        public IGalleryImageRepository GalleryImageRepo { get; set; }
        public GalleryService(IGalleryImageRepository galleryRepo)
        {
            GalleryImageRepo = galleryRepo;
        }
        public List<GalleryImage> GetAll()
        {
            return GalleryImageRepo.GetAll();
        }
    }
}

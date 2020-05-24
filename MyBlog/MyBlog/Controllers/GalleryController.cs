using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyBlog.Service.Interfaces;

namespace MyBlog.Controllers
{
    public class GalleryController : Controller
    {
        public IGalleryService GalleryService { get; set; }
        public GalleryController(IGalleryService galleryService)
        {
            GalleryService = galleryService;
        }
        public IActionResult Overview()
        {
            ViewBag.header = "Gallery";
            var galleryImages = GalleryService.GetAll();
            return View(galleryImages);
        }
    }
}
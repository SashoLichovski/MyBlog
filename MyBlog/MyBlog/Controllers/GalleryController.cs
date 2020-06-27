using System.Collections.Generic;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MyBlog.Service.Interfaces;
using MyBlog.ViewModels.GalleryModels;

namespace MyBlog.Controllers
{
    public class GalleryController : Controller
    {
        private readonly IMapper mapper;

        public IGalleryService GalleryService { get; set; }
        public GalleryController(IGalleryService galleryService, IMapper mapper)
        {
            GalleryService = galleryService;
            this.mapper = mapper;
        }
        public IActionResult Overview()
        {
            ViewBag.header = "Gallery";
            var galleryImages = GalleryService.GetAll();
            var convertedList = new List<OverviewModel>();
            galleryImages.ForEach(x => convertedList.Add(mapper.Map<OverviewModel>(x)));
            return View(convertedList);
        }
    }
}
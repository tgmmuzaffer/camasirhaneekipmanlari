using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Web.Models;
using Web.Models.Dtos;
using Web.Repository.IRepository;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ICategoryRepo _categoryRepo;
        private readonly ISliderRepo _sliderRepo;
        private readonly IBlogRepo _blogRepo;
        private readonly IReferanceRepo _referanceRepo;

        public HomeController(ILogger<HomeController> logger ,ICategoryRepo categoryRepo, ISliderRepo sliderRepo, IBlogRepo blogRepo, IReferanceRepo referanceRepo)
        {
            _logger = logger;
            _categoryRepo = categoryRepo;
            _blogRepo= blogRepo;
            _sliderRepo = sliderRepo;
            _referanceRepo = referanceRepo;
        }

        public async Task<IActionResult> Index()
        {
            var categories = await _categoryRepo.GetList(StaticDetails.getAllCategoriesName);
            var slider = await _sliderRepo.GetList(StaticDetails.getAllSlidersIsShow);
            var blogs = await _blogRepo.GetList(StaticDetails.getAllBlogs);
            blogs = blogs.Take(4).ToList();
            var referances = await _referanceRepo.GetList(StaticDetails.getAllReferances);

            ViewBag.Categories = categories;
            ViewBag.Slider = slider;
            ViewBag.ThreeBlog = blogs;
            ViewBag.Refrences = referances;

            return View();
        }

    }
}

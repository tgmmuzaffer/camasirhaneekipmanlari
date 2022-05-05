using AspNetCore.SEOHelper.Sitemap;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
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
        private readonly IWebHostEnvironment _env;
        private readonly IActionDescriptorCollectionProvider _actionDescriptorCollectionProvider;
        private readonly IFeatureDescriptionRepo _featureDescriptionRepo;


        public HomeController(ILogger<HomeController> logger ,ICategoryRepo categoryRepo, ISliderRepo sliderRepo, IBlogRepo blogRepo, IReferanceRepo referanceRepo, IWebHostEnvironment env, IActionDescriptorCollectionProvider actionDescriptorCollectionProvider, IFeatureDescriptionRepo featureDescriptionRepo)
        {
            _logger = logger;
            _categoryRepo = categoryRepo;
            _blogRepo= blogRepo;
            _sliderRepo = sliderRepo;
            _referanceRepo = referanceRepo;
            _env = env;
            _actionDescriptorCollectionProvider = actionDescriptorCollectionProvider;
            _featureDescriptionRepo = featureDescriptionRepo;

        }

        [ResponseCache(Duration = 2650000, Location = ResponseCacheLocation.Any)]
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
        [Route("/Sikca-Sorulan-Sorular")]
        [ResponseCache(Duration = 2650000, Location = ResponseCacheLocation.Any)]
        public IActionResult Faq()
        {

            TempData["Page"] = "Sıkça Sorulan Sorular";
            TempData["BreadCrumb"] = new List<string> { "Sıkça Sorulan Sorular" };
            return View();
        }



        [Route("/Site-Haritasi")]
        [ResponseCache(Duration = 2650000, Location = ResponseCacheLocation.Any)]
        public async Task<IActionResult> Sitemap()        
        {
            var categorydata = await _categoryRepo.GetList(StaticDetails.getAllCategories);
            var branddata = await _featureDescriptionRepo.GetList(StaticDetails.getAllfeatureDescriptionsByFeatureId + 1);
            var blog = await _blogRepo.GetList(StaticDetails.getAllBlogs);

            ViewBag.CategoryDatas = categorydata;
            ViewBag.BrandsDatas = branddata;
            ViewBag.Blog = blog;
            TempData["Page"] = "Site Haritası";
            TempData["BreadCrumb"] = new List<string> { "Site Haritası" };


            return View();
        }

    }
}

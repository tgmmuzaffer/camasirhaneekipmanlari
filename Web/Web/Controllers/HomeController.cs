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

        public HomeController(ILogger<HomeController> logger ,ICategoryRepo categoryRepo, ISliderRepo sliderRepo, IBlogRepo blogRepo, IReferanceRepo referanceRepo, IWebHostEnvironment env, IActionDescriptorCollectionProvider actionDescriptorCollectionProvider)
        {
            _logger = logger;
            _categoryRepo = categoryRepo;
            _blogRepo= blogRepo;
            _sliderRepo = sliderRepo;
            _referanceRepo = referanceRepo;
            _env = env;
            _actionDescriptorCollectionProvider = actionDescriptorCollectionProvider;

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
        [Route("/sitemap.xml")]
        public IActionResult SitemapXml()
        
        {
            //.Where(ad => ad.AttributeRouteInfo != null && ad.AttributeRouteInfo.Name != null)

            var routes = _actionDescriptorCollectionProvider.ActionDescriptors.Items.ToList();
              
            var list = new List<SitemapNode>();

            //list.Add(new SitemapNode { LastModified = DateTime.UtcNow, Priority = 0.8, Url = "https://codingwithesty.com/serilog-mongodb-in-asp-net-core", Frequency = SitemapFrequency.Daily });
            //list.Add(new SitemapNode { LastModified = DateTime.UtcNow, Priority = 0.8, Url = "https://codingwithesty.com/logging-in-asp-net-core", Frequency = SitemapFrequency.Yearly });
            //list.Add(new SitemapNode { LastModified = DateTime.UtcNow, Priority = 0.7, Url = "https://codingwithesty.com/robots-txt-in-asp-net-core", Frequency = SitemapFrequency.Monthly });
            //list.Add(new SitemapNode { LastModified = DateTime.UtcNow, Priority = 0.5, Url = "https://codingwithesty.com/versioning-asp.net-core-apiIs-with-swagger", Frequency = SitemapFrequency.Weekly });
            //list.Add(new SitemapNode { LastModified = DateTime.UtcNow, Priority = 0.4, Url = "https://codingwithesty.com/configuring-swagger-asp-net-core-web-api", Frequency = SitemapFrequency.Never });

            //new SitemapDocument().CreateSitemapXML(list, _env.ContentRootPath);
            return View();
        }

    }
}

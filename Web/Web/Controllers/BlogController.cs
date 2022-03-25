using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Models;
using Web.Models.Dtos;
using Web.Repository.IRepository;

namespace Web.Controllers
{
    public class BlogController : BaseController
    {
        private readonly IBlogRepo _blogRepo;
        public BlogController(IMemoryCache memoryCache, IBlogRepo blogRepo) : base(memoryCache)
        {
            _blogRepo= blogRepo;
        }

        [Route(template: "Blog")]
        public async Task<IActionResult> BlogList()
        {
            var blog = await _blogRepo.GetList(StaticDetails.getAllBlogs);
            #region BreadCrumb
            TempData["BreadCrumb"] = new List<string> { "Blog" };
            TempData["Page"] = "Blog";
            #endregion

            return View(blog);
        }

        [Route(template: "Blog/{Id}")]
        public async Task<IActionResult> BlogDetail(int Id)
        {
            var blogdetail = await _blogRepo.Get(StaticDetails.getBlog + Id);
            List<Blog> blogs = new();
            var cacheValue = GetCacheDataBlog(GetCacheKey());
            if (cacheValue == null || cacheValue.Count == 0)
            {
                blogs = await _blogRepo.GetList(StaticDetails.getAllBlogs);
                blogs = blogs.Take(3).ToList();
                ViewBag.ThreeBlog = blogs;

                string key = GetCacheKey();
                AddCacheDataBlog(key, blogs);
                #region BreadCrumb
                TempData["BreadCrumb"] = new List<string> { "Blog" };
                TempData["Page"] = blogdetail.Title;
                #endregion
                return View(blogdetail);
            }

            cacheValue = cacheValue.Take(3).ToList();
            ViewBag.ThreeBlog = cacheValue;
            #region BreadCrumb
            TempData["BreadCrumb"] = new List<string> { "Blog"};
            TempData["Page"] =  blogdetail.Title;
            #endregion
            return View(blogdetail);
        }
    }
}

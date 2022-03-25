using Microsoft.AspNetCore.Mvc;
using Recaptcha.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Models;
using Web.Models.Dtos;
using Web.Repository.IRepository;

namespace Web.Controllers
{
    public class AboutUsController : Controller
    {
        private readonly IAboutUsRepo _aboutUsRepo;
        public AboutUsController(IAboutUsRepo aboutUsRepo)
        {
            _aboutUsRepo = aboutUsRepo;
        }


        [Route(template: "/Hakkimizda")]
        public async Task<IActionResult> AboutUs()
        {
            var aboutUsData = await _aboutUsRepo.Get(StaticDetails.getAboutUs);
            TempData["Page"] = "Hakkımızda";
            TempData["BreadCrumb"] = new List<string> { "Hakkımızda" };

            return View(aboutUsData);
        }

    
    }
}

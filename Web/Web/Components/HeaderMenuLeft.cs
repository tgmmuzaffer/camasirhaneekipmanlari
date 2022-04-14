using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Models;
using Web.Repository.IRepository;

namespace Web.Components
{
    public class HeaderMenuLeft : ViewComponent
    {
        private readonly ICategoryRepo _categoryRepo;
        private readonly IFeatureDescriptionRepo _featureDescriptionRepo;
        public HeaderMenuLeft(ICategoryRepo categoryRepo, IFeatureDescriptionRepo featureDescriptionRepo)
        {
            _categoryRepo = categoryRepo;
            _featureDescriptionRepo = featureDescriptionRepo;
        }
        [ResponseCache(Duration = 2650000, Location = ResponseCacheLocation.Any)]
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var categorydata = await _categoryRepo.GetList(StaticDetails.getAllCategories);
            // id marka id si bilreek sabit verildi 1
            var branddata = await _featureDescriptionRepo.GetList(StaticDetails.getAllfeatureDescriptionsByFeatureId+1);


            ViewBag.CategoryDatas = categorydata;
            ViewBag.BrandsDatas = branddata;
            return View();
        }
    }
}

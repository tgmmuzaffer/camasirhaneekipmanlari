using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Models;
using Web.Repository.IRepository;

namespace Web.Controllers
{
    public class BrandController : Controller
    {
        private readonly IFeatureRepo _featureRepo;
        private readonly IFeatureDescriptionRepo _featureDescriptionRepo;
        public BrandController(IFeatureRepo featureRepo, IFeatureDescriptionRepo featureDescriptionRepo)
        {
            _featureRepo = featureRepo;
            _featureDescriptionRepo = featureDescriptionRepo;
        }


        [Route("Markalar")]
        public async Task<IActionResult> AllBrands()
        {
            var feature = await _featureRepo.Get(StaticDetails.getFeatureByName + "Marka");
            var brands = await _featureDescriptionRepo.GetList(StaticDetails.getAllfeatureDescriptionsByFeatureId + feature.Id);
            #region BreadCrumb
            TempData["BreadCrumb"] = new List<string> { "Markalar" };
            TempData["Page"] = "Markalar";
            #endregion
          
            return View(brands);
        }
        
     
    }
}

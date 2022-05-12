using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using System.Collections.Generic;
using System.Threading.Tasks;
using Web.Models;
using Web.Models.Dtos;
using Web.Repository.IRepository;

namespace Web.Controllers
{
    public class IndustryController : BaseController
    {
        private readonly IIndustryRepo _industryRepo;
        public IndustryController(IMemoryCache memoryCache, IIndustryRepo industryRepo ): base(memoryCache)
        {
            _industryRepo = industryRepo;
        }

        [Route(template: "/Sektorler")]
        [ResponseCache(Duration = 2650000, Location = ResponseCacheLocation.Any)]
        public async Task<IActionResult> Industries()
        {
                List<IndustryDto>industryDto = new();
                industryDto = await _industryRepo.GetList(StaticDetails.getIndustries);
                #region BreadCrumb
                TempData["BreadCrumb"] = new List<string> { "Sektörler" };
                TempData["Page"] = "Sektörler";
                #endregion

                return View(industryDto);
           
        }
    }
}

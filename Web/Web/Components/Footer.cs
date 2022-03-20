using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Web.Models;
using Web.Models.Dtos;
using Web.Repository.IRepository;

namespace Web.Components
{
    public class Footer :ViewComponent
    {
        private readonly IContactRepo _contactRepo;
        public Footer(IContactRepo contactRepo)
        {
            _contactRepo = contactRepo;
        }
        public async Task<IViewComponentResult> InvokeAsync(string url)
        {
            var contactdata = await _contactRepo.Get(StaticDetails.getContact);
            ViewBag.Url = url;
            return View(contactdata);
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Web.Models.Dtos;

namespace Web.Components
{
    public class GetOfferForm : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(string Name)
        {
            Mail mail = new() { Subject=Name};
            return View(mail);
        }
    }
}

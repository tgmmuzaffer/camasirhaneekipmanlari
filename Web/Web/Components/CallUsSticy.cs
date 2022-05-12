using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Web.Components
{
    public class CallUsSticy : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}

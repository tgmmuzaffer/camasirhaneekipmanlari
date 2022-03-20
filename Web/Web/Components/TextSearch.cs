using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Web.Models.Dtos;

namespace Web.Components
{
    public class TextSearch :ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(ProductDto productDto)
        {
            return View(productDto);
        }
    }
}

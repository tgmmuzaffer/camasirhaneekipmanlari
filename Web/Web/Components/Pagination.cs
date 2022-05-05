using Microsoft.AspNetCore.Mvc;
using Web.Models.Dtos;

namespace Web.Components
{
    public class Pagination : ViewComponent
    {
        //ctor

        public IViewComponentResult Invoke(PagedData pagedData)
        {
            return View(pagedData);
        }
    }
}

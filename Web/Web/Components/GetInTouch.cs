using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Models.Dtos;

namespace Web.Components
{
    public class GetInTouch : ViewComponent
    {

        public async Task<IViewComponentResult> InvokeAsync(Contact contact)
        {
            return View(contact);
        }
    }
}

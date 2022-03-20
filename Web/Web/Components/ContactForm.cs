using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Models.Dtos;

namespace Web.Components
{
    public class ContactForm : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            Mail mail = new();
            return View(mail);
        }
    }
}

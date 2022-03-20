using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Models.Dtos;

namespace Web.Components
{
    public class BreadCrumb :  ViewComponent
    {
        //ctor

        public IViewComponentResult Invoke(Breadcrumb breadcrumb)
        {
            return View(breadcrumb);
        }
    }
}

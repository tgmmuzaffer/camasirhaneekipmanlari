﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Components
{
    public class HomePageText : ViewComponent
    {
        //ctor

        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

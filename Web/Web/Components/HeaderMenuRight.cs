﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Components
{
    public class HeaderMenuRight : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

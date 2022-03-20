using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Controllers
{
    public class ErrorController : Controller
    {
        [Route("notfound")]
        public IActionResult Notfound()
        {
            return View();
        }
    }
}

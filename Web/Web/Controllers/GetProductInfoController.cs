using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Controllers
{
    public class GetProductInfoController : Controller
    {

        /*
         * Her üründe bir button olacak 
         * butona tıkladığında ürüne ait bilgi buraya gelicek
         * sepet sayısı artaca
         * sepet ekranı ekleme çıkarma işlemi yapılacak
         * burada cookiye ekleme çıkarma işlemleri yapılacak 
         * robot.txt ile bu rotanı indexlenmemesi sağlanmalı
         */
        [Route("getproductInfo")]
        public IActionResult Index()
        {
            return Json(0);
        }
    }
}

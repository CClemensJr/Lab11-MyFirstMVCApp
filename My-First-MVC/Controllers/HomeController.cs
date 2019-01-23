using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace My_First_MVC.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        //[HttpPost]
        //public IActionResult Index(int startYear, int endYear)
        //{
        //    RedirectToAction("Results", Results);
        //}

        //[HttpGet]
        //public IActionResult Results()
        //{
        //    return View();
        //}
    }
}

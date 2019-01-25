using Microsoft.AspNetCore.Mvc;
using My_First_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace My_First_MVC.Controllers
{
    public class HomeController : Controller
    {
        /// <summary>
        /// Displays the index page
        /// </summary>
        /// <returns>Returns the view</returns>
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Gets the span of years from the user
        /// </summary>
        /// <param name="startYear"></param>
        /// <param name="endYear"></param>
        /// <returns>redirects to the results action while sending the user input along</returns>
        [HttpPost]
        public IActionResult Index(int startYear, int endYear)
        {
            return RedirectToAction("Results", new { startYear, endYear });
        }

        /// <summary>
        /// Sends the start and end years to the GetPersons method in the model then sends it to the view for display
        /// </summary>
        /// <param name="startYear"></param>
        /// <param name="endYear"></param>
        /// <returns>Returns the persons of the years between the dates specified</returns>
        [HttpGet]
        public IActionResult Results(int startYear, int endYear)
        {
            // Do what we want with the number
            return View(TimePerson.GetPersons(startYear, endYear));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Moonie.Helpers;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace MvcMovie.Controllers
{
    public class MoonController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            ViewBag.activePage = "Moon";
            return View();
        }

        public IActionResult Moon()
        {
            var birthDate = new DateTime(1986, 6, 3);
            ViewBag.age = HelperFunctions.AgeCalculation(birthDate);

            ViewBag.activePage = "Moon";
            return View();
        }

        public IActionResult Jason()
        {
            var birthDate = new DateTime(1991, 2, 17);
            ViewBag.age = HelperFunctions.AgeCalculation(birthDate);

            ViewBag.activePage = "Jason";
            return View();
        }
    }
}

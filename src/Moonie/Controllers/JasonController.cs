using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Moonie.Helpers;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Moonie.Controllers
{
    public class JasonController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
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

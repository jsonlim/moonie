using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Moonie.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.activePage = "Home";
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";
            ViewBag.activePage = "About";
            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";
            ViewBag.activePage = "Contact";
            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}

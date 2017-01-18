using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // 
        // GET: /HelloWorld/

        public ViewResult Index()
        {
            return View();
        }

        // 
        // GET: /HelloWorld/Welcome/ 
        // Query string would be /HelloWorld/Welcome?name=xxx&numTimes=2
        /*ID is optional, see in StartUp.cs
         * app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}"); <--- ? in id? means optional.
            });

            So can be HelloWorld/Welcome?name=xxx&numTimes=x (id would be whatever value if given in parameters)
            or HelloWorld/Welcome/1?

    */
        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }
    }
}
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using ValidationMessage.Models;

namespace ValidationMessage.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult display(string n, string e, string f)
        {

            if (string.IsNullOrEmpty(n))
            {
                ModelState.AddModelError("n", "full name is required field");

            }
            if (string.IsNullOrEmpty(e))
            {
                ModelState.AddModelError("e", "email  is required field");

            }
            if (string.IsNullOrEmpty(f))
            {
                ModelState.AddModelError("f", "field name is required field");

            }

            if (!ModelState.IsValid)
            {
                // If ModelState is not valid, return the same view with validation errors
                return View("Index");
            }
            Employee emp = new Employee();
            emp.Name_Emp = n;
            emp.Email_Emp = e;
            emp.Field_Emp = f;

            // Return the display view with the Employee model
             return View("display", emp);
           

        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

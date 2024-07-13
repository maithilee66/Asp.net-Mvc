using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {

        //     url for this action method =>http://localhost:xxxx/Home/Index
        public string Index()
        {
            return "this is index page";
        }



        //     url for this action method =>http://localhost:xxxx/Home/Name
        public string Name()
        {
            return "what is name";
        }


        public ActionResult aboutUs()
        {
            return View();
            // this will execute (return ) the aboutUs.cshtml

        }
    }
}

/*

@*
    For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860
*@
@{
}
*/

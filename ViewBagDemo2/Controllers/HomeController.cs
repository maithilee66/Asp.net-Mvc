using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViewBagDemo.Models;
/*
    1. ViewBag is used to send data from controller to view

    2. syntax
        ViewBag.key=value;
            the key is a variable of dynamic type therfore at runtime it decides the type of value

    3. Like ViewData we do not need to do typecasting here 
           eg . in index.cshtml accssing the fruits array
                foreach (var i in ViewBag.fruits)
                    {
                         <h3>@ViewBag.i</h3>

                     }
 */
namespace ViewBagDemo.Controllers
{
    public class HomeController : Controller
    {
        
        public ActionResult Index()
        {
          //  1. String type
            ViewBag.msg = "this is view bag messgae varibale";

            //  2. Int type
            ViewBag.num = 10;

            //  3. Array type
            ViewBag.fruits = new string[] { "apple", "banana", "grapes" };

            //or 
            string[] fruits2 = { "apple", "banana", "grapes" };
            ViewBag.f2 = fruits2;

            //  4. Lit type
            ViewBag.games = new List<string> { 
            "football","hockey"
            };

            //  5. Object type
                Employee e=new Employee();
            e.Emp_id = 1;
            e.Emp_name = "John";

            ViewBag.emp = e;

            
            return View();
        }
    }
}
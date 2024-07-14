using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using ViewDataDemo.Models;
/*
1.  View Data is used to send data from controller to view

2. ViewData only transfers data from controller to view, not vice-versa. It is valid only during the current request.

3. syntax
    ViewData["key"]=value;

   here the value can be 
         1. string
         2. 
 */
namespace ViewDataDemo.Controllers
{
    public class HomeController : Controller
    {
       
        public ActionResult Index()
        {
            //1. val is string type
            string val = "hello this is view data1";
            ViewData["message1"] = val;
            ViewData["message2"] = "hello this is view data";


            //2. int type
            int num = 321;
            ViewData["NUMBER1"]=num;
            ViewData["NUMBER2"] = 123;

            //3. ARRAY TYPE
            string[] fruits = { "apple", "banana", "orange" };
            ViewData["f_array"] = fruits;


            //4. list type 
            ViewData["fruits_list"] = new List<string>()
            {
                "apple", "banana", "orange"
            };

            //5.  object type
            //create a obj from class employee present in models folder
            //for this we need to add using ViewDataDemo.Models;   (that is solutionanme.foldername)
            Employee e = new Employee();
            e.Emp_id = 435;
            e.Emp_name = "john";

            ViewData["emp_variable"] = e;
            return View();
        }
    }
}
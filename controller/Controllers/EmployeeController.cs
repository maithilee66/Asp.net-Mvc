using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    public class EmployeeController : Controller
    {
        public string checkId(int i)
        {
            switch (i)
            {
                case 1:
                    return "this is employeee whith id 1";
                //break;
                case 2:
                    return "this is employeee whith id 2";
                // break;
                default:
                    return $"no employeee whith id {i}";
                    //break;



                    /*  when http://localhost:xxxx/employee/checkid?i=1
         it displays => this is employeee whith id 1


       when http://localhost:xxxx/employee/checkid?i=9
         it displays=> no employeee whith id 9

       */

            }


        }

        //to pass more than one parameter

        public string Display(int id, string dept) { 
         return $"id={id} , deptartment ={dept}";


            /*
           1.   http://localhost:xxxx/employee/display?id=99&dept="tech"

            will display => id=99 , deptartment ="tech"


              2.   http://localhost:xxxx/employee/display?id=99&dept=tech

            will display => id=99 , deptartment =tech


            no need to give "tech" in url are it will take input in given data type only 
            */
        }
    }
}

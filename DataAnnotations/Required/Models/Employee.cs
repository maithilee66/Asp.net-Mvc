using iassess.Models;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
namespace iassess.Models
{
    public class Employee
    {
        [Required (ErrorMessage="id field is needed")]
        public int? id { get; set; }

        [Required(ErrorMessage = "name field is needed")]
        public string name { get; set; }

        [Required]
        public int? age { get; set; }

        [Required]
        public double? tax { get; set; }
    }
}
/*

1. the required field message is bind with @Html.ValidationMessageFor(model => model.age) so we need to write both 
2. veh message dikhata hain actually ValidationMessageFor
2.add ? for nullabel types(such as int, double, or DateTime)
4. we can also add custom message
[Required(ErrorMessage = "name likh")]

[Required] its default message =>The name field is required.
5. @Html.ValidationMessageFor(model => model.age,"",new {@class="text-danger"})
6.     if (!ModelState.IsValid)
            {
                return View("display");
            }
*/

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


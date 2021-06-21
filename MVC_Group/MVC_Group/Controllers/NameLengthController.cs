using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Group.Controllers
{
    public class NameLengthController : Controller
    {
        public async Task<IActionResult> NameLength()
        {
            return View(viewName: "NameLength", model: "Please enter your last name and age");
        }

        [HttpPost]

        public async Task<IActionResult> Difference(string inputLastName, int inputAge)
        {
            int dif = Math.Abs(inputLastName.Length - inputAge);



            return View(viewName: "NameLength", model: "Absolute value of the difference between length of last name and your age: " + dif);
        }



    }
}

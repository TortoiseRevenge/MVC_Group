using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Group.Controllers
{
    public class AgeController : Controller
    {
        public async Task<IActionResult> Age()
        {
            return View(viewName: "Age", model: "Please enter your birthday");
        }

        [HttpPost]

        public async Task<IActionResult> Old(DateTime inputBirthday)
        {
            
            DateTime localDate = DateTime.Now;


            var numDays = (localDate - inputBirthday).TotalDays;
            if(numDays < 0)
            {
                return View(viewName: "Age", model: "You have entered a date in the future. Please try again!");

            }
            int age = (int)numDays / 365;

            return View(viewName: "Age", model: "Age: " + age +  ", Current Date: " + DateTime.Now + ", Inputted Date: " + inputBirthday + "" +
                                                                "Year User was born: " + inputBirthday.Year);
        }
    }
}

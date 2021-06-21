using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Group.Controllers
{
    public class StrMathMethods : Controller
    {
        public async Task<IActionResult> Index()
        {
            return View(viewName: "Index", model: "Please enter stuff.");
        }
        [HttpPost]
        public async Task<IActionResult> RandomInt(string lastName, int age)
        {
            int lnLength = lastName.Length;
            double differenceMath = lnLength - age;
            double finalAnswer = Math.Abs(differenceMath);
            return View(viewName: "Index", model: "Math Stuff: " + finalAnswer);
        }
    }
}

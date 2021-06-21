using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Group.Controllers
{
    public class SquareNumberController : Controller
    {
        public async Task<IActionResult> Index()
        {
            return View(viewName: "Index", model: "Please enter integers.");
        }
        [HttpPost]
        public async Task<IActionResult> SquareTheNumber(double inputInt, double inputInt2)
        {
            return View(viewName: "Index", model: "Cube: " + (inputInt * inputInt * inputInt) + " Square Root: " + (Math.Sqrt(inputInt2)));

        }
    }
}

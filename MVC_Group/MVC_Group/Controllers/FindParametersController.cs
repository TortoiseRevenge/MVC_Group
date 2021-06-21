using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Group.Controllers
{
    public class FindParametersController : Controller
    {
        Random rd = new Random();
        public async Task<IActionResult> Index()
        {
            return View(viewName: "Index", model: "Please enter numbers.");
        }
        [HttpPost]
        public async Task<IActionResult> RandomInt(int inputInt, int inputInt2)
        {           
                return View(viewName: "Index", model: "Random Number: " + rd.Next(inputInt, inputInt2));          
        }
    }
}

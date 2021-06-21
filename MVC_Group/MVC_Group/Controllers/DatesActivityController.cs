using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Group.Controllers
{
    public class DatesActivityController : Controller
    {
        public async Task<IActionResult> Index()
        {
            return View(viewName: "Index", model: "Please enter stuff.");
        }
        [HttpPost]
        public async Task<IActionResult> RandomInt(string inputdate)
        {          
            DateTime timeNow = DateTime.Now;           
            DateTime newDt = DateTime.Parse(inputdate);
            return View(viewName: "Index", model: "Inputted Date: " + newDt);
            
        }
    }
}

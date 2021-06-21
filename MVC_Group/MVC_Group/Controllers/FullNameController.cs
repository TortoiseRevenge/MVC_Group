using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Group.Controllers
{
    public class FullNameController : Controller
    {
        public async Task<IActionResult> Index()
        {
            return View(viewName: "Index", model: "Please enter numbers.");
        }
        [HttpPost]
        public async Task<IActionResult> RandomInt(string name1, string name2)
        {
            string fullName = string.Concat(name1, name2);
            return View(viewName: "Index", model: "Full Name: " + fullName);
        }
    }
}

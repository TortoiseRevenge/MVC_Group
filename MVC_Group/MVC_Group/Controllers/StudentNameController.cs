using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Group.Controllers
{
    public class StudentNameController : Controller
    {
        public async Task<IActionResult> StudentName()
        {
            return View(viewName: "StudentName", model: "Please enter your first and last name");
        }

        [HttpPost]

        public async Task<IActionResult> FullName(string inputName1, string inputName2)
        {
            
            return View(viewName: "StudentName", model: "Student Name: " + inputName1+inputName2);
        }




    }
}

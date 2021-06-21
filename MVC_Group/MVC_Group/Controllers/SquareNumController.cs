using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Group.Controllers
{
    public class SquareNumController : Controller
    {
        public async Task<IActionResult> SquareNum()
        {
            return View(viewName: "SquareNum", model: "Please enter two numbers.");
        }
       
        [HttpPost]
        public async Task<IActionResult> Square(int inputNum1, int inputNum2)
        {
            return View(viewName: "SquareNum", model: "Square of the First Number: " + inputNum1*inputNum1 + " , Square of the Second Number: " + inputNum2*inputNum2);
        }
       



    }
}

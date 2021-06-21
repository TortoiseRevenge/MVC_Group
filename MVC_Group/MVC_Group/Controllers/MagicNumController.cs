using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Group.Controllers
{
    public class MagicNumController : Controller
    {
        public async Task<IActionResult> MagicNum()
        {
            return View(viewName: "MagicNum", model: "Please enter a lower bound and an upper bound");
        }

        [HttpPost]
        public async Task<IActionResult> Random(int inputNum1, int inputNum2)
        {
            var rand = new Random();
            int num = 0;
            if (inputNum1 <= inputNum2) {
                num = rand.Next(inputNum1, inputNum2);
                    }
            else
            {
                return View(viewName: "MagicNum", model: "You have entered an invalid input, try again");   
            }
            return View(viewName: "MagicNum", model: "Magic Number: " + num);
        }




    }
}

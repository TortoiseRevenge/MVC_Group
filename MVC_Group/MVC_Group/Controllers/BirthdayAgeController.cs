using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Group.Controllers
{
    public class BirthdayAgeController : Controller
    {
        public async Task<IActionResult> Index()
        {
            return View(viewName: "Index", model: "Please enter stuff.");
        }
        [HttpPost]
        public async Task<IActionResult> RandomInt(string birthday)
        {
            DateTime newDt = DateTime.Parse(birthday);
            DateTime timeNow = DateTime.Now;           
            TimeSpan ageNum = timeNow.Subtract(newDt);
            int age = ageNum.Days;
            int finalAge = age / 365;

            return View(viewName: "Index", model: "Age: " + finalAge);
        }
    }
}

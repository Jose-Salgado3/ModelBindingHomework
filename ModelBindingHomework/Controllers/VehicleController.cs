using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ModelBindingHomework.Models;

namespace ModelBindingHomework.Controllers
{
    public class VehicleController : Controller
    {
        [HttpGet]
        public IActionResult Apply()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Apply(IFormCollection data)
        {

            Vehicle v = new Vehicle()
            {
                FullName = data["full-name"],
                Make = data["make"],
                Model = data["model"],
                Year = Convert.ToInt32(data["year"]),
                Miles = Convert.ToInt32(data["miles"])
            };


            //ADD TO DATABASE HERE!!!!
            return View();
        }


        //FOR Homework here is the model binding View!
        [HttpGet]
        public IActionResult ApplyMB()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ApplyMB(Vehicle v)
        {
            if (ModelState.IsValid)
            {
                // Add to database
                // Alert successs
                ViewData["Success"] = "Registration was successful!";
                return View();
            }
            return View();
        }
    }
}
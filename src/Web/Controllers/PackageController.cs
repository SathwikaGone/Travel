using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Web.Models;

namespace Web.Controllers
{
    public class PackageController : Controller
    {
        public IActionResult text()
        {
            return Content("Hello!");

        }

        public IActionResult JSON()
        {
            
              
             return  Json(new {name="Kullu", quote="This is my favorite place."});
          

        }
         
        public IActionResult HTML(){
            var things= "<!DOCTYPE html><html><body>Things to buy for a tour" + 
      "<br> 1) Visas, documents, and travel details. <br> 2) Shoes <br>3) Immunizations, first aid. <br>"+
 "<br>4) Backpack Internet, laptops, and phones. <br> </body></html>";
            return Content(things, "text/html");

        }
                public IActionResult Package(){
            return View();
        }

        // [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        // public IActionResult Error()
        // {
        //     return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        // }
    }
}

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
            var things= "<!DOCTYPE html><html><body>This is HTML page.<br>Things to buy for a tour" + 
         "<br> 1) Visas, documents, and travel details. <br> 2) Backpack Internet, laptops, and phones. <br>3) Immunizations, first aid."+
        "<br>4) Shoes.<br> </body></html>";
            return Content(things, "text/html");

        }
                public IActionResult Package(){
            return View();
        }

    }
}

using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPDotnetCore_MVCDemo.Models;

namespace ASPDotnetCore_MVCDemo.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return Content("Hello from MVC core");
        }

        public IActionResult GetEmployee()
        {
            var emp = new Employee {Id=101,Name="Sharan" };
            return Json(emp);
        }

        public ActionResult SayHello()
        {
            return View();
        }
    }
}

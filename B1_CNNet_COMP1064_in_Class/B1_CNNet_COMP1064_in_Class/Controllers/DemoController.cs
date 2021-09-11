using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace B1_CNNet_COMP1064_in_Class.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public ViewResult ActionIndex()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.LoiChao = hour < 12 ? "Chào buổi sáng" : "Chào buổi chiều";
            return View("MyView");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace myFirstMVCWeek2.Controllers
{
    public class HomeController : Controller
    {
        private string[] groenten = {"rode kool","spruit", "wortel","spinazie"};

        /*public string Index(string word)
        {
            ViewBag.Groet = "hi";
            return $"cute {word}";
        }*/

        public ViewResult Index()
        {
            ViewBag.Groenten = groenten;
            return View();
        }
    }
}
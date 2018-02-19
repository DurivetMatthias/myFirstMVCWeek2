using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyHowestWeek2;


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

        public ViewResult Student()
        {
            List<Student> studenten = new List<Student>
            {
                new Student { Id = 1, Naam = "Matthias", AfstudeerGraad = Graad.voldoening},
                new Student {Id = 2, Naam = "doggo", AfstudeerGraad = Graad.onderscheiding}
            };
            ViewBag.studenten = studenten;
            return View();
        }
    }
}
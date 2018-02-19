using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace myFirstMVCWeek2.Controllers
{
    public class HomeController : Controller
    {
        public string Index(string word)
        {
            return $"cute {word}";
        }
    }
}
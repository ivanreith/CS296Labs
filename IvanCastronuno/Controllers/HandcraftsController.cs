using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace IvanCastronuno.Controllers
{
    public class Handcrafts : Controller
    {
        public IActionResult HandcraftsIndex()
        {
            return View();
        }
        public IActionResult Projects()
        {
            return View();
        }
        public IActionResult Tutorials()
        {
            return View();
        }
    }
}

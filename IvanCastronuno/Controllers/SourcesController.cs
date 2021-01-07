using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace IvanCastronuno.Controllers
{
    public class SourcesController : Controller
    {
        public IActionResult SourcesIndex()
        {
            return View();
        }
        public IActionResult Books()
        {
            return View();
        }
        public IActionResult Links()
        {
            return View();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using IvanCastronuno.Models;
using Microsoft.EntityFrameworkCore;

namespace IvanCastronuno.Controllers
{
    public class HomeController : Controller
    {
      /* private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }*/
        // Start database adding stuff
        private StoryContext Context { get; set; }

        public HomeController(StoryContext ctx)
        {
            Context = ctx;
        }

        public IActionResult Stories()
        {
            var stories = Context.Stories.Include(m => m.Poster)
                .OrderBy(m => m.StoryTopic).ToList();
            return View(stories);
        }
        // End database adding stuff 
        
        public IActionResult Index()
        {
            return View();
        }
       
        public IActionResult History()
        {
            return View();
        }
        [HttpPost]
        public IActionResult History(QuizAnswers model)
        {

            return View(model);

        }
        /*
        public IActionResult Stories()

          
             {

           
                //  ViewBag.FV = 99999;  Something for the empty
                return View();
            }
            [HttpPost]
            public IActionResult Stories(StoriesModelForm model)
            {
              
                    return View(model);
            
            }*/
   
        public IActionResult SourcesIndex()
        {
            return View();
        }
        public IActionResult HandcraftsIndex()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

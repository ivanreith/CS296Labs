using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using IvanCastronuno.Models;
using Microsoft.EntityFrameworkCore;
using IvanCastronuno.Repositories;
using Microsoft.AspNetCore.Authorization;

namespace IvanCastronuno.Controllers
{
    public class HomeController : Controller
    {
      /* private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }*/// keep that part just in case
        // Start database adding stuff
        private StoryContext Context { get; set; }
        IStories Repo;
        public HomeController(IStories r, StoryContext ctx)
        {
            Repo = r;
            Context = ctx;
        }

        public IActionResult Stories()
        {

            List<StoriesModelForm> stories = Repo.stories.ToList<StoriesModelForm>();

            return View(stories);
            /*  List<StoriesModelForm> stories = Context.Story.Include(m => m.Poster)
                .OrderBy(m => m.StoryTopic).ToList();
            return View(stories);*/ // = > moved due to repository

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

        public IActionResult AdminIndex()
        {
            return View();
        }

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

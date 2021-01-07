using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using IvanCastronuno.Models;
using IvanCastronuno.Repositories;

namespace IvanCastronuno.Controllers
{
    public class StoryController : Controller
    {
        // StoryContext c,  Context = c;
        IStories Repo;
        StoryContext Context { get; set; }

        public StoryController(IStories r, StoryContext c)
        {
            Context = c;
            Repo = r;
        }

        [HttpGet]
        public IActionResult Add(StoriesModelForm story)
        {
            ViewBag.Action = "Add";
            ViewBag.Users = Context.User.OrderBy(g => g.UserName).ToList();
            return View("Edit", story);// new StoriesModelForm()
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";
            ViewBag.Users = Context.User.OrderBy(g => g.UserName).ToList();
            var story = Repo.GetStoryById(id);
            /*
            var story = Context.Stories.Find(id);*/
            return View(story);
        }

       /* public void AddStory(StoriesModelForm story)
        {
            Repo.AddStory(story);
        }
       */
        [HttpPost]
        public IActionResult Edit(StoriesModelForm story)
        {
            if (ModelState.IsValid)
            {
                if (story.StoryID == 0 )
                {
                    Repo.AddStory(story);
                }
                //
                else
                    Repo.UpdateStory(story);
                   
                return RedirectToAction("Stories", "Home");
            }
            else
            {
                ViewBag.Action = (story.StoryID == 0) ? "Add" : "Edit";
                ViewBag.Users = Repo.stories.OrderBy(story => story.Poster.UserName).ToList();
                return View(story);
            }
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            
            var story = Context.Stories.Find(id);
            return View(story);
        }

        [HttpPost]
        public IActionResult Delete(StoriesModelForm story)
        {
            Repo.DeleteStory(story);
            return RedirectToAction("Stories", "Home");
        }
        public IActionResult Stories()
        {

            List<StoriesModelForm> stories = Repo.stories.ToList<StoriesModelForm>();

                return View(stories);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using IvanCastronuno.Models;
using IvanCastronuno.Repositories;
using Microsoft.AspNetCore.Identity;


namespace IvanCastronuno.Controllers
{
    
    public class StoryController : Controller
    {
        // StoryContext c,  Context = c; ==>> Now using the repo for the most part
        IStories Repo;
       StoryContext Context { get; set; }
        UserManager<AppUser> userManager;
        public StoryController(IStories r, StoryContext c, UserManager<AppUser> u)
        {
           Context = c;
            Repo = r;
            userManager = u;
        }
        [Authorize]
        [HttpGet]
        public IActionResult Add()  //StoriesModelForm story  => it doesn't need the object , it's empty
        {
         
               var story = new StoriesModelForm();
               // story.Name = User.Identity.Name; field removed from story model
                story.StoryID = 0;
                ViewBag.Action = "Add";
                ViewBag.Users = Context.AppUser.OrderBy(g => g.Name).ToList();
                return View("Edit", story);// new StoriesModelForm() 
           
        }
        [Authorize]
        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";
            ViewBag.Users = Context.AppUser.OrderBy(g => g.Name).ToList();
            var story = Repo.GetStoryById(id);
           
          //  var story = Context.Story.Find(id);
            return View(story);
        }

        [Authorize]
        [HttpPost]
        public IActionResult Edit(StoriesModelForm story)
        {
            if (ModelState.IsValid)
            {
                if (story.StoryID == 0)
                {
                    story.Poster = userManager.GetUserAsync(User).Result;
                    story.Poster.Name = story.Poster.UserName;
                    // story.Name = User.Identity.Name;  field removed from story model
                    // story.Poster.Name = User.Identity.Name;
                    Repo.AddStory(story);
                }
                
                else
                {
                    story.Poster = userManager.GetUserAsync(User).Result;
                    story.Poster.Name = story.Poster.UserName; // temporary fix
                    //  story.Name = story.Poster.UserName;
                    Repo.UpdateStory(story);
                    return RedirectToAction("Stories", "Home");
                }
                return RedirectToAction("Stories", "Home");
            }
            else
            {
                // ViewBag.Action = (story.StoryID == 0) ? "Add" : "Edit";   ==>> I leave these two line because where the ones giving me trouble
                // ViewBag.Users = Repo.stories.OrderBy(story => story.Poster.Name).ToList(); => that was bad but never got tested until input testing
                ViewBag.Users = Context.AppUser.OrderBy(g => g.Name).ToList();
                return View(story);
            }
        }
        [Authorize]
        [HttpGet]
        public IActionResult Delete(int id)
        {
            
            var story = Context.Story.Find(id);
            return View(story);
        }
        [Authorize(Roles = "Admin")]
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

        [Authorize]
        [HttpGet]
        public IActionResult Comment()
        {
            return View();
        }


        [Authorize]
        [HttpPost]
        public IActionResult Comment(CommentModel comment)
        {

            comment.Commenter = userManager.GetUserAsync(User).Result;
            comment.Commenter.Name = comment.Commenter.UserName;
            comment.CommentDate = DateTime.Now;

            return View(comment);

        }

    }
}
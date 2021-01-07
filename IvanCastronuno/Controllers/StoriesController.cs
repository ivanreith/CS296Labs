using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using IvanCastronuno.Models;
using System.Reflection.Metadata;

namespace IvanCastronuno.Controllers
{
    public class Story : Controller
    {
   
        public IActionResult Stories()
        {
           
            ViewBag.story = null;
            //  ViewBag.FV = 99999;  Something for the empty
            return View();
        }
        [HttpPost]
        public IActionResult Stories(StoriesModelForm model)
        {
            if (ModelState.IsValid)
            {
              
                ViewBag.story = model;
                return Stories(model);
            }
            else
            {
               model = new StoriesModelForm();
                ViewBag.story = model;
                return Stories(model);
            }
        }
    }   

    /*
    //The code Below comes with the template
    // GET: StoriesController
    public ActionResult Index()
     {
         return View();
     }

    
    // GET: StoriesController/Create
    public ActionResult Create()
    {
        return View();
    }

    // POST: StoriesController/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Create(IFormCollection collection)
    {
        try
        {
            return RedirectToAction(nameof(Index));
        }
        catch
        {
            return View();
        }
    }

    // GET: StoriesController/Edit/5
    public ActionResult Edit(int id)
    {
        return View();
    }

    // POST: StoriesController/Edit/5
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Edit(int id, IFormCollection collection)
    {
        try
        {
            return RedirectToAction(nameof(Index));
        }
        catch
        {
            return View();
        }
    }

    // GET: StoriesController/Delete/5
    public ActionResult Delete(int id)
    {
        return View();
    }

    // POST: StoriesController/Delete/5
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Delete(int id, IFormCollection collection)
    {
        try
        {
            return RedirectToAction(nameof(Index));
        }
        catch
        {
            return View();
        }
    }*/
}


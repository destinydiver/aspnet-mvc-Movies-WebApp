using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MoviesWebApp.Data;
using MoviesWebApp.Data.Services;
using MoviesWebApp.Models;
using System;

namespace MoviesWebApp.Controllers
{
    public class ActorsController : Controller
    {
        private readonly IActorsService _service;

        public ActorsController(IActorsService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            var allActors = await _service.GetAllAsync();
            return View(allActors);
        }

        //GET:  Actors/Create
        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("FullName,ProfilePictureURL,Bio")] Actor actor)
        {
            // Below code was added to ck ModelState errors
            //var errors = ModelState
            //    .Where(x => x.Value.Errors.Count > 0)
            //    .Select(x => new { x.Key, x.Value.Errors })
            //    .ToArray();
            if (!ModelState.IsValid)
            {
                return View(actor);
            }

            await _service.AddAsync(actor);
            return RedirectToAction(nameof(Index));
        }

        // GET: Actors/Details/id
        public async Task<IActionResult> Details(int id)
        {
            var actorDetails = await _service.GetByIdAsync(id);
            if (actorDetails == null) return View("NotFound");
            return View(actorDetails);
        }

        //GET:  Actors/Edit/id
        public async Task<IActionResult> Edit(int id)
        {
            var actorToEdit = await _service.GetByIdAsync(id);
            if (actorToEdit == null) return View("NotFound");
            return View(actorToEdit);
        }

        //POST: Actors/Edit/id
        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FullName,ProfilePictureURL,Bio")] Actor actor)
        {
            if (!ModelState.IsValid)
            {
                return View(actor);
            }

            await _service.UpdateAsync(id, actor);
            return RedirectToAction(nameof(Index));
        }

        //GET:  Actors/Delete/id
        public async Task<IActionResult> Delete(int id)
        {
            var actorToDelete = await _service.GetByIdAsync(id);
            if (actorToDelete == null) return View("NotFound");
            return View(actorToDelete);
}

        //I am using the [ActionName] attribute here(below) as an action selector which is used for a different name
        //of the action method.We use[ActionName] attribute when we want that action
        //method to be called with a different name instead of the actual name of the method.
        //I am using this method to deal with not being able to have two methods with the same name & signature.
        //So below, I have the DeleteConfirmed method but the action is called by just "Delete"

        //POST: Actors/Delete
        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var actorToDelete = await _service.GetByIdAsync(id);
            if (actorToDelete == null) return View("NotFound");

            await _service.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}



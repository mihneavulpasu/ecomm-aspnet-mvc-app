using eTickets.Data;
using eTickets.Data.Services;
using eTickets.Models;
using Microsoft.AspNetCore.Mvc;

namespace eTickets.Controllers
{
    public class ActorsController : Controller
    {
        public readonly IActorsService _service;

        public ActorsController(IActorsService service)
        {
            _service = service;
        }



        public IActionResult Index()//This action result name needs to be the same as the name of the cshtml file
        {
            var allActors = _service.GetAll();
            return View(allActors);
        }




        //Get request at: Actors/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create([Bind("FullName, ProfilePictureUrl, Bio")] Actor actor) //async Task<IActionResult>
                                                                                            //we use this to send data to the database
        {
            if (!ModelState.IsValid) //for example when you create an actor and do not provide any data the model will not be valid
            {
                return View(actor);
            }
            _service.Add(actor); //after writing this we go to Data -> Services -> ActorsService -> add method
            return RedirectToAction("Index");
        }




        //Get request at: Actors/Details/id
        public IActionResult Details(int id)
        {
            var actorDetails = _service.GetById(id);

            if (actorDetails == null)
            {
                return View("NotFound");
            }
            return View(actorDetails);
        }





        //Get request at: Actors/Edit
        public IActionResult Edit(int id)
        {
            var actorDetails = _service.GetById(id);

            if (actorDetails == null)
            {
                return View("NotFound");
            }
            return View(actorDetails);
        }

        [HttpPost]
        public IActionResult Edit(int id, [Bind("Id, FullName, ProfilePictureUrl, Bio")] Actor actor) // we could also remove the Bind as we definded every property of the actor so it should work anyway
        {
            if (!ModelState.IsValid) //for example when you edit an actor and do not provide any data the model will not be valid
            {
                return View(actor);
            }
            _service.Update(id, actor); //after writing this we go to Data -> Services -> ActorsService -> add method
            return RedirectToAction("Index");
        }




        //Get request at: Actors/Delete/Id
        public IActionResult Delete(int id)
        {
            var actorDetails = _service.GetById(id); //checking if the actor exists

            if (actorDetails == null)
            {
                return View("NotFound");
            }
            return View(actorDetails);
        }

        [HttpPost]
        public IActionResult DeleteConfirmed(int id)
        {
            var actorDetails = _service.GetById(id);
            if (actorDetails == null)
            {
                return View("NotFound");
            }

            _service.Delete(id);
            return RedirectToAction("Index");
        }
    }
}

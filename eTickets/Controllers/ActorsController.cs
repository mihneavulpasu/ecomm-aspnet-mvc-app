using eTickets.Data;
using eTickets.Data.Services;
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

        public IActionResult Create() //Simple Get request at Actors/Create
        { 
            return View();
        }
    }
}

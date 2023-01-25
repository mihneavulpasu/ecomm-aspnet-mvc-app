using eTickets.Data;
using eTickets.Data.Services;
using eTickets.Models;
using Microsoft.AspNetCore.Mvc;

namespace eTickets.Controllers
{
    public class ProducersController : Controller
    {
        public readonly IProducersService _service;

        public ProducersController(IProducersService service)
        {
            _service = service;
        }




        public IActionResult Index() //public async Task<IActionResult> Index()
        {
            var allProducers = _service.GetAll(); //var allProducers = await _context.Producers.ToListAsync();
            return View(allProducers); //in the View we need to define the name of the view but if we leave index no need to specify cause it is default
        }




        //GET: producers/Details/id
        public IActionResult Details(int id) 
        {
            var producerDetails = _service.GetById(id);
            if (producerDetails == null)
            {
                return View("NotFound");
            }
            return View(producerDetails); 
        }



        //GET: producers/create
        public IActionResult  Create() 
        { 
            return View();
        }

        [HttpPost]
        public IActionResult Create([Bind("ProfilePictureUrl, FullName, Bio")]Producer producer) 
        {
            if (!ModelState.IsValid) 
            {
                return View(producer);
            }
            _service.Add(producer);
            return RedirectToAction("Index");
        }



        //GET: producers/edit/id
        public IActionResult Edit(int id)
        {
            var producerDetails = _service.GetById(id);

            if (producerDetails == null)
            {
                return View("NotFound");
            }
            return View(producerDetails);
        }

        [HttpPost]
        public IActionResult Edit(int id, [Bind("Id, ProfilePictureUrl, FullName, Bio")] Producer producer)
        {
            if (!ModelState.IsValid)
            {
                return View(producer);
            }
            //if (id == producer.Id)
            //{
                _service.Update(id, producer);
                return RedirectToAction("Index");
            //}
           //return View(producer);
           //idk why he wrote it like this it works fine i guess without it as the actors work the same :P
        }



        //GET: producers/delete/id
        public IActionResult Delete(int id)
        {
            var producerDetails = _service.GetById(id);

            if (producerDetails == null)
            {
                return View("NotFound");
            }
            return View(producerDetails);
        }

        [HttpPost]
        public IActionResult DeleteConfirmed(int id)
        {
            var producersDetails = _service.GetById(id);

            if (producersDetails == null)
            {
                return View("NotFound");
            }
            _service.Delete(id);
            return RedirectToAction("Index");
        }

    }
}

using eTickets.Data;
using eTickets.Data.Services;
using eTickets.Models;
using Microsoft.AspNetCore.Mvc;

namespace eTickets.Controllers
{
    public class CinemasController : Controller
    {
        private readonly ICinemasService _service;
        public CinemasController(ICinemasService service)
        {
            _service = service;
        }
        public IActionResult Index() //public async Task<IActionResult> Index()
        {
            var allCinemas = _service.GetAll(); //var allCinemas = await _context.Cinemas.ToListAsync();
            return View(allCinemas);
        }

        //GET: cinemas/create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create([Bind("Logo, Name, Description")] Cinema cinema)
        {
            if (!ModelState.IsValid)
            {
                return View(cinema);
            }
            _service.Add(cinema);
            return RedirectToAction("Index");
        }

        //GET: cinemas/Details/id
        public IActionResult Details(int id)
        {
            var cinemaDetails = _service.GetById(id);
            if (cinemaDetails == null)
            {
                return View("NotFound");
            }
            return View(cinemaDetails);
        }

        //GET: cinemas/edit/id
        public IActionResult Edit(int id)
        {
            var cinemaDetails = _service.GetById(id);

            if (cinemaDetails == null)
            {
                return View("NotFound");
            }
            return View(cinemaDetails);
        }

        [HttpPost]
        public IActionResult Edit(int id, [Bind("Id, Logo, Name, Description")] Cinema cinema)
        {
            if (!ModelState.IsValid)
            {
                return View(cinema);
            }
            _service.Update(id, cinema);
            return RedirectToAction("Index");
        }

        //GET: cinemas/delete/id
        public IActionResult Delete(int id)
        {
            var cinemaDetails = _service.GetById(id);

            if (cinemaDetails == null)
            {
                return View("NotFound");
            }
            return View(cinemaDetails);
        }

        [HttpPost]
        public IActionResult DeleteConfirmed(int id)
        {
            var cinemaDetails = _service.GetById(id);

            if (cinemaDetails == null)
            {
                return View("NotFound");
            }
            _service.Delete(id);
            return RedirectToAction("Index");
        }
    }
}

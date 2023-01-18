using eTickets.Data;
using Microsoft.AspNetCore.Mvc;

namespace eTickets.Controllers
{
    public class ActorsController : Controller
    {
        private readonly AppDbContext _context;
        public ActorsController(AppDbContext context)
        {
            _context = context;
        }
    
        public IActionResult Index()//This action result name needs to be the same as the name of the cshtml file
        {
            var allActors = _context.Actors.ToList();
            return View(allActors);
        }
    }
}

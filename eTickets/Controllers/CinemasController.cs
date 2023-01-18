using eTickets.Data;
using Microsoft.AspNetCore.Mvc;

namespace eTickets.Controllers
{
    public class CinemasController : Controller
    {
        private readonly AppDbContext _context;
        public CinemasController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index() //public async Task<IActionResult> Index()
        {
            var allCinemas = _context.Cinemas.ToList(); //var allCinemas = await _context.Cinemas.ToListAsync();
            return View(allCinemas);
        }
    }
}

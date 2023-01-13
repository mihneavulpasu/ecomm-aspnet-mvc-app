using eTickets.Data;
using Microsoft.AspNetCore.Mvc;

namespace eTickets.Controllers
{
    public class MoviesController : Controller
    {
        private readonly AppDbContext _context;
        public MoviesController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()//public async Task<IActionResult> Index()
        {
            var allMovies = _context.Movies.ToList(); //var allMovies = await _context.Movies.ToListAsync();
            return View();
        }
    }
}

using eTickets.Data;
using Microsoft.AspNetCore.Mvc;

namespace eTickets.Controllers
{
    public class ProducersController : Controller
    {
        private readonly AppDbContext _context;
        public ProducersController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index() //public async Task<IActionResult> Index()
        {
            var allProducers = _context.Producers.ToList(); //var allProducers = await _context.Producers.ToListAsync();
            return View(allProducers); //in the View we need to define the name of the view but if we leave index no need to specify cause it is default
        }
    }
}

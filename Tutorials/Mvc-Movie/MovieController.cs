using System;

namespace MvcMovie.Controllers
{
    public class MovieController : Controller
    {
        private readonly ApplicatioDbContext context;
        public MovieController(ApplicationDbContext _context)
        {
            context = _context;
        } 
        public async Task<IActionResult> Index()
        {
            return View(await context.Movie.ToListAsync());
        }
    } 
}
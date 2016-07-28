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

        public async Task<IActionResult> Details(int? id)
        {
            // sanitizing the args
            if(id==null)
            {
                return NotFound();
            }
            var movie = await context.Movie.FindAsync(id);
            if(movie==null)
            {
                return NotFound();
            }
            return View(movie);
        }
    } 
}
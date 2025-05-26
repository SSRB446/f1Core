using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using f1Core.Data;
using f1Core.Models;

namespace f1Core.Controllers
{
    public class RaceController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RaceController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var races = await _context.Races.Include(r => r.Circuit).Include(r => r.Season)
                          .OrderBy(r => r.Date).ToListAsync();
            return View(races);
        }

        public async Task<IActionResult> Details(int id)
        {
            var race = await _context.Races
                .Include(r => r.Circuit)
                .Include(r => r.Season)
                .FirstOrDefaultAsync(r => r.RaceId == id);
            if (race == null) return NotFound();

            return View(race);
        }
    }
}

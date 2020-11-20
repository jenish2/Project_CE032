using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BookMyTickets.Models;
using Microsoft.AspNetCore.Http;

namespace BookMyTickets.Controllers
{
    public class ShowsController : Controller
    {
        private readonly AppDbContext _context;

        public ShowsController(AppDbContext context)
        {
            _context = context;
        }

        
        public IActionResult BookingPhase1(IFormCollection fc)
        {
            if(HttpContext.Session.GetString("UserName") == "")
            {
                return RedirectToAction("SignInForUser", "Users");
            }
            else
            {
                ViewBag.Name = fc["MovieName"];
                string Mname = fc["MovieName"].ToString();
                var movie = _context.Movies.FirstOrDefault(m => m.MovieName == Mname);
                if (movie == null)
                {
                    return RedirectToAction("Index", "Home");
                }

                return View("movieDetailsForBookingPhase1", movie);
            }
        }


        public IActionResult findShowsBookingPhase2(IFormCollection fc)
        {
            string Mname = fc["MovieName"].ToString();
            string city = fc["City"].ToString();
            var movie = _context.Movies.FirstOrDefault(m => m.MovieName == Mname);
            if (movie == null)
            {
                return RedirectToAction("Index", "Home");
            }
            ViewBag.MovieName = movie.MovieName;
            ViewBag.Genre = movie.Genre;
            ViewBag.Language = movie.Language;
            ViewBag.Duretion = movie.Duretion;
            ViewBag.ReleaseDate = movie.ReleaseDate;
            ViewBag.Director = movie.Director;
            ViewBag.Url = movie.PosterUrl;
            var showDetails = _context.Shows.Where(x => x.MovieName == Mname && x.City == city).ToList();
            return View(showDetails);
        }

        // GET: Shows
        public async Task<IActionResult> Index()
        {
            var appDbContext = _context.Shows.Include(s => s.Movie).Include(s => s.Theater);
            return View(await appDbContext.ToListAsync());
        }

        // GET: Shows/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var show = await _context.Shows
                .Include(s => s.Movie)
                .Include(s => s.Theater)
                .FirstOrDefaultAsync(m => m.ShowId == id);
            if (show == null)
            {
                return NotFound();
            }

            return View(show);
        }

        // GET: Shows/Create
        public IActionResult Create()
        {
            ViewData["MovieId"] = new SelectList(_context.Movies, "MovieId", "MovieName");
            ViewData["TheaterId"] = new SelectList(_context.Theaters, "TheaterId", "TheaterName");
            return View();
        }

        // POST: Shows/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ShowId,MovieId,TheaterId,MovieName,TheaterName,City,ScreenNo,Date,StartTime,Price")] Show show)
        {
            if (ModelState.IsValid)
            {
                _context.Add(show);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Create));
            }
            ViewData["MovieId"] = new SelectList(_context.Movies, "MovieId", "MovieName", show.MovieId);
            ViewData["TheaterId"] = new SelectList(_context.Theaters, "TheaterId", "TheaterName", show.TheaterId);
            return View(show);
        }

        // GET: Shows/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var show = await _context.Shows.FindAsync(id);
            if (show == null)
            {
                return NotFound();
            }
            ViewData["MovieId"] = new SelectList(_context.Movies, "MovieId", "MovieName", show.MovieId);
            ViewData["TheaterId"] = new SelectList(_context.Theaters, "TheaterId", "TheaterName", show.TheaterId);
            return View(show);
        }

        // POST: Shows/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ShowId,MovieId,TheaterId,MovieName,TheaterName,City,ScreenNo,Date,StartTime,Price")] Show show)
        {
            if (id != show.ShowId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(show);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ShowExists(show.ShowId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["MovieId"] = new SelectList(_context.Movies, "MovieId", "MovieName", show.MovieId);
            ViewData["TheaterId"] = new SelectList(_context.Theaters, "TheaterId", "TheaterName", show.TheaterId);
            return View(show);
        }

        // GET: Shows/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var show = await _context.Shows
                .Include(s => s.Movie)
                .Include(s => s.Theater)
                .FirstOrDefaultAsync(m => m.ShowId == id);
            if (show == null)
            {
                return NotFound();
            }

            return View(show);
        }

        // POST: Shows/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var show = await _context.Shows.FindAsync(id);
            _context.Shows.Remove(show);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ShowExists(int id)
        {
            return _context.Shows.Any(e => e.ShowId == id);
        }
    }
}

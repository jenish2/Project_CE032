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
    public class BookingsController : Controller
    {
        private readonly AppDbContext _context;
        int showId;
        public BookingsController(AppDbContext context)
        {
            _context = context;
        }
        
        public IActionResult ConfirmBookingPhase4(IFormCollection fc)
        {
            ViewBag.TotalTickets = fc["TotalTickets"];
            int totalTickets = Int32.Parse(fc["TotalTickets"]);
            int seat1 = Int32.Parse(fc["Seat1"]);
            int seat2 = Int32.Parse(fc["Seat2"]);
            int seat3 = Int32.Parse(fc["Seat3"]);
            showId = Int32.Parse(fc["ShowId"]);
           
            Booking book = new Booking();
            if (seat3 == 0)
            {
                var bookingSeat = _context.Bookings.FirstOrDefault(x => x.ShowId == showId && x.UserName == HttpContext.Session.GetString("UserName") && (x.SeatNo1 == seat1));
                if (bookingSeat != null)
                {
                    return RedirectToAction("BookingPhase1", "Shows");
                }
                else
                {
                    book.TotalTickets = totalTickets;
                    book.SeatNo1 = seat1;
                    book.SeatNo2 = seat2;
                    book.SeatNo3 = seat3;
                    book.ShowId = showId;
                    var Show = _context.Shows.FirstOrDefault(x => x.ShowId == showId);
                    var user = _context.Users.FirstOrDefault(x => x.UserName == HttpContext.Session.GetString("UserName"));
                    var movie = _context.Movies.FirstOrDefault(x => x.MovieName == Show.MovieName);
                    book.UserName = HttpContext.Session.GetString("UserName");
                    book.MovieName = Show.MovieName;
                    book.ScreenNo = Show.ScreenNo;
                    book.TheaterName = Show.TheaterName;
                    book.UserId = user.UserId;
                    book.City = Show.City;
                    book.Date = Show.Date;
                    string bill = (Show.Price).ToString();
                    int bill2 = Int32.Parse(bill);
                    double Cost = ((1.18) * (bill2 * totalTickets));
                    book.TotalCost = Cost;
                    ViewBag.Url = movie.PosterUrl;
                    ViewBag.MovieName = movie.MovieName;
                    ViewBag.Language = movie.Language;
                    ViewBag.Genre = movie.Genre;
                    ViewBag.Director = movie.Director;
                    ViewBag.Duretion = movie.Duretion;
                    ViewBag.ReleseDate = movie.ReleaseDate;
                    ViewBag.StartTime = Show.StartTime;
                    ViewBag.Price = Show.Price;
                    _context.Add(book);
                    _context.SaveChanges();
                    return View(book);
                }

            }
            else if (seat2 == 0 && seat3 == 0)
            {
                var bookingSeat = _context.Bookings.FirstOrDefault(x => x.ShowId == showId && x.UserName == HttpContext.Session.GetString("UserName") && (x.SeatNo1 == seat1));
                if (bookingSeat != null)
                {
                    return RedirectToAction("BookingPhase1", "Shows");
                }
                else
                {
                    book.TotalTickets = totalTickets;
                    book.SeatNo1 = seat1;
                    book.SeatNo2 = seat2;
                    book.SeatNo3 = seat3;
                    book.ShowId = showId;
                    var Show = _context.Shows.FirstOrDefault(x => x.ShowId == showId);
                    var user = _context.Users.FirstOrDefault(x => x.UserName == HttpContext.Session.GetString("UserName"));
                    var movie = _context.Movies.FirstOrDefault(x => x.MovieName == Show.MovieName);
                    book.UserName = HttpContext.Session.GetString("UserName");
                    book.MovieName = Show.MovieName;
                    book.ScreenNo = Show.ScreenNo;
                    book.TheaterName = Show.TheaterName;
                    book.UserId = user.UserId;
                    book.City = Show.City;
                    book.Date = Show.Date;
                    string bill = (Show.Price).ToString();
                    int bill2 = Int32.Parse(bill);
                    double Cost = ((1.18) * (bill2 * totalTickets));
                    book.TotalCost = Cost;
                    ViewBag.Url = movie.PosterUrl;
                    ViewBag.MovieName = movie.MovieName;
                    ViewBag.Language = movie.Language;
                    ViewBag.Genre = movie.Genre;
                    ViewBag.Director = movie.Director;
                    ViewBag.Duretion = movie.Duretion;
                    ViewBag.ReleseDate = movie.ReleaseDate;
                    ViewBag.StartTime = Show.StartTime;
                    ViewBag.Price = Show.Price;
                    _context.Add(book);
                    _context.SaveChanges();
                    return View(book);
                }

            }
            else
            {
                var bookingSeat = _context.Bookings.FirstOrDefault(x => x.ShowId == showId && x.UserName == HttpContext.Session.GetString("UserName") && (x.SeatNo1 == seat1 || x.SeatNo2 == seat2 || x.SeatNo3 == seat3));
                if (bookingSeat != null)
                {
                    return RedirectToAction("BookingPhase1", "Shows");
                }
                else
                {
                    book.TotalTickets = totalTickets;
                    book.SeatNo1 = seat1;
                    book.SeatNo2 = seat2;
                    book.SeatNo3 = seat3;
                    book.ShowId = showId;
                    var Show = _context.Shows.FirstOrDefault(x => x.ShowId == showId);
                    var user = _context.Users.FirstOrDefault(x => x.UserName == HttpContext.Session.GetString("UserName"));
                    var movie = _context.Movies.FirstOrDefault(x => x.MovieName == Show.MovieName);
                    book.UserName = HttpContext.Session.GetString("UserName");
                    book.MovieName = Show.MovieName;
                    book.ScreenNo = Show.ScreenNo;
                    book.TheaterName = Show.TheaterName;
                    book.UserId = user.UserId;
                    book.City = Show.City;
                    book.Date = Show.Date;
                    string bill = (Show.Price).ToString();
                    int bill2 = Int32.Parse(bill);
                    double Cost = ((1.18) * (bill2 * totalTickets));
                    book.TotalCost = Cost;
                    ViewBag.Url = movie.PosterUrl;
                    ViewBag.MovieName = movie.MovieName;
                    ViewBag.Language = movie.Language;
                    ViewBag.Genre = movie.Genre;
                    ViewBag.Director = movie.Director;
                    ViewBag.Duretion = movie.Duretion;
                    ViewBag.ReleseDate = movie.ReleaseDate;
                    ViewBag.StartTime = Show.StartTime;
                    ViewBag.Price = Show.Price;
                    _context.Add(book);
                    _context.SaveChanges();
                    return View(book);
                }


            }
        }

        public IActionResult seatSelectionBookingPhase3(IFormCollection fc)
        {
            ViewBag.ShowId = fc["ShowId"];
            showId = Int32.Parse(fc["ShowId"]);
            var Show = _context.Shows.FirstOrDefault(x=> x.ShowId == showId);
            var Movie = _context.Movies.FirstOrDefault(x => x.MovieName == Show.MovieName );
            ViewBag.MovieName = Movie.MovieName;
            ViewBag.Url = Movie.PosterUrl;
            ViewBag.Language = Movie.Language;
            ViewBag.Genre = Movie.Genre;
            ViewBag.Director = Movie.Director;
            ViewBag.Duretion = Movie.Duretion;
            ViewBag.ReleaseDate = Movie.ReleaseDate;
            ViewBag.TheaterName = Show.TheaterName;
            ViewBag.StartTime = Show.StartTime;
            ViewBag.ScreenNo = Show.ScreenNo;
            ViewBag.Date = Show.Date;
            ViewBag.Price = Show.Price;

            return View();
        }

        public IActionResult SoldTickets()
        {
            var sold = _context.Bookings.Where(x => x.TheaterName == HttpContext.Session.GetString("TheaterName")).ToList();
            return View(sold);
        }

        public IActionResult BookedTicketsOfUser()
        {
            var booking = _context.Bookings.Where(x => x.UserName == HttpContext.Session.GetString("UserName")).ToList();
            return View(booking);
        }
        // GET: Bookings
        public async Task<IActionResult> Index()
        {
            var appDbContext = _context.Bookings.Include(b => b.Show).Include(b => b.User);
            return View(await appDbContext.ToListAsync());
        }

        // GET: Bookings/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var booking = await _context.Bookings
                .Include(b => b.Show)
                .Include(b => b.User)
                .FirstOrDefaultAsync(m => m.BookingId == id);
            if (booking == null)
            {
                return NotFound();
            }

            return View(booking);
        }

        // GET: Bookings/Create
        public IActionResult Create()
        {
            ViewData["ShowId"] = new SelectList(_context.Shows, "ShowId", "ShowId");
            ViewData["UserId"] = new SelectList(_context.Users, "UserId", "Email");
            return View();
        }

        // POST: Bookings/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("BookingId,UserId,ShowId,TotalTickets,SeatNo1,SeatNo2,SeatNo3,TotalCost,Date,MovieName,TheaterName,UserName,City,ScreenNo")] Booking booking)
        {
            if (ModelState.IsValid)
            {
                _context.Add(booking);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ShowId"] = new SelectList(_context.Shows, "ShowId", "ShowId", booking.ShowId);
            ViewData["UserId"] = new SelectList(_context.Users, "UserId", "Email", booking.UserId);
            return View(booking);
        }

        // GET: Bookings/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var booking = await _context.Bookings.FindAsync(id);
            if (booking == null)
            {
                return NotFound();
            }
            ViewData["ShowId"] = new SelectList(_context.Shows, "ShowId", "ShowId", booking.ShowId);
            ViewData["UserId"] = new SelectList(_context.Users, "UserId", "Email", booking.UserId);
            return View(booking);
        }

        // POST: Bookings/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("BookingId,UserId,ShowId,TotalTickets,SeatNo1,SeatNo2,SeatNo3,TotalCost,Date,MovieName,TheaterName,UserName,City,ScreenNo")] Booking booking)
        {
            if (id != booking.BookingId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(booking);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BookingExists(booking.BookingId))
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
            ViewData["ShowId"] = new SelectList(_context.Shows, "ShowId", "ShowId", booking.ShowId);
            ViewData["UserId"] = new SelectList(_context.Users, "UserId", "Email", booking.UserId);
            return View(booking);
        }

        // GET: Bookings/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var booking = await _context.Bookings
                .Include(b => b.Show)
                .Include(b => b.User)
                .FirstOrDefaultAsync(m => m.BookingId == id);
            if (booking == null)
            {
                return NotFound();
            }

            return View(booking);
        }

        // POST: Bookings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var booking = await _context.Bookings.FindAsync(id);
            _context.Bookings.Remove(booking);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BookingExists(int id)
        {
            return _context.Bookings.Any(e => e.BookingId == id);
        }
    }
}

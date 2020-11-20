using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BookMyTickets.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace BookMyTickets.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AppDbContext _context;
        public HomeController(AppDbContext context, ILogger<HomeController> logger)
        {
            _logger = logger;
            _context = context;
        }
        
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            if(HttpContext.Session.GetString("UserName")== null)
            {
                HttpContext.Session.SetString("UserName", "");
            }
            if (HttpContext.Session.GetString("TheaterName")==null)
            {
                HttpContext.Session.SetString("TheaterName", "");
            }
            return View(await _context.Movies.ToListAsync());
        }
        [HttpPost]
        public IActionResult Index(Movie item)
        {
           /* TempData["MovieForBooking"] = item;*/
            return RedirectToAction("BookingPhase1","Shows");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult AboutUs()
        {
            return View();
        }

        [HttpGet]
        public IActionResult ContactUs()
        {
            return View();
        }

       


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Project1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project1.Controllers
{
    public class HomeController : Controller
    {
        private TourDbContext context { get; set; }
        //Constructor
        public HomeController(TourDbContext con)
        {
            context = con;
        }

        public IActionResult Index()
        {
            return View(context.Tours);
        }
        [HttpGet]
        public IActionResult SignUp()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SignUp(TourGroup t)
        {
            if (ModelState.IsValid)
            {
                context.Tours.Add(t);
                context.SaveChanges();
            }
            return View();
        }

        public IActionResult SignUpTime()
        {
            return View();
        }
    }
}

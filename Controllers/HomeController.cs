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

        private ITourRepo _repository;
        //Constructor
        public HomeController(TourDbContext con, ITourRepo repository)
        {
            context = con;
            _repository = repository;
        }

        public IActionResult Index()
        {
            return View(_repository.Tours);
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
                context.TourGroups.Add(t);
                context.SaveChanges();
            }
            return View();
        }

        public IActionResult Groups()
        {
            return View(context.TourGroups);
        }
    }
}

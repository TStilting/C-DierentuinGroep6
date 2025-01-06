using DierentuinGroep6.Data;
using DierentuinGroep6.Models;
using Microsoft.AspNetCore.Mvc;

namespace DierentuinGroep6.Controllers
{
    public class AnimalController : Controller
    {
        private readonly ZooContext _context;

        public AnimalController(ZooContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var animals = _context.Animals.ToList();
            return View(animals);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Animal animal)
        {
            if (ModelState.IsValid)
            {
                _context.Animals.Add(animal);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(animal);
        }

    }
}

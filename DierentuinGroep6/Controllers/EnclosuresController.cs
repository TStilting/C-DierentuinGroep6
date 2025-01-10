using DierentuinGroep6.Data;
using DierentuinGroep6.Models;
using Microsoft.AspNetCore.Mvc;

namespace DierentuinGroep6.Controllers
{
    public class EnclosuresController : Controller
    {
        private readonly ZooContext _context;

        public EnclosuresController(ZooContext context)
        {
            _context = context;
        }

        // Index Actie
        public IActionResult Index()
        {
            var enclosures = _context.Enclosures.ToList();  // Haal de enclosures op uit de database
            return View(enclosures);  // Return de view met de lijst van enclosures
        }

        // Create Actie
        public IActionResult Create()
        {
            return View();  // Return de view voor het maken van een nieuwe enclosure
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Enclosure enclosure)
        {
            if (ModelState.IsValid)
            {
                _context.Add(enclosure);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(enclosure);
        }
    }
}

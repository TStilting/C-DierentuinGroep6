using DierentuinGroep6.Data;
using DierentuinGroep6.Models;
using Microsoft.AspNetCore.Mvc;

namespace DierentuinGroep6.Controllers
{
    public class EnclosureController : Controller
    {
        private readonly ZooContext _context;

        public EnclosureController(ZooContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var enclosures = _context.Enclosures.ToList();
            return View(enclosures);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Enclosure enclosure)
        {
            if (ModelState.IsValid)
            {
                _context.Enclosures.Add(enclosure);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(enclosure);
        }

    }
}

using Microsoft.AspNetCore.Mvc;
using DierentuinGroep6.Models;

namespace DierentuinGroep6.Controllers
{
    public class AnimalsController : Controller
    {
        // GET: /Animals
        [HttpGet]
        public IActionResult Index()
        {
            // Haal hier je dieren op uit de database
            return View(); // Dit zou een View moeten zijn zoals Animals/Index.cshtml
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
                // Voeg het dier toe aan de database
                return RedirectToAction("Index");
            }
            return View(animal);
        }
    }
}

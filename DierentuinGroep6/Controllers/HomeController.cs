using Microsoft.AspNetCore.Mvc;

namespace DierentuinGroep6.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

//using System.Diagnostics; //(for logger)
using Microsoft.AspNetCore.Mvc;
using spellstoringitem.Models;

namespace spellstoringitem.Controllers
{
    public class HomeController : Controller
    {
        //logger will be implemented later to track database interactions to track adding/deleting homebrew content
        //private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AddSpell()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddSpell(NewSpell spell)
        {
            return View("ConfirmAdd", spell);
        }

        public IActionResult Mission05()
        {
            return View();
        }
    }
}

using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using spellstoringitem.Models;

namespace spellstoringitem.Controllers
{
    public class HomeController : Controller
    {
        //logger will be implemented later to track database interactions
        //private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Calculator()
        {
            return View();
        }

    }
}

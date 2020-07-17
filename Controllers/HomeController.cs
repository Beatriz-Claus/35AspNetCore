using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Aula35_AspNetCore.Models;

namespace Aula35_AspNetCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
// O Index retorne um resutado de uma ação, que é uma view
        public IActionResult Index()
        {
            ViewBag.Teste = "Texto de teste para o viewBag";
            ViewBag.TesteDois = 2111.3f;
            return View();
        }
// Privacy retorna um resutado de uma ação, que é uma view
        public IActionResult Privacy()
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

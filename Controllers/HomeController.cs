using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PI_MVC_SQL.Models;

namespace PI_MVC_SQL.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult carrodestaque()
        {
            return View();
        }

         public IActionResult custobeneficio()
        {
            return View();
        }

         public IActionResult destaques()
        {
            return View();
        }

         public IActionResult emissaozero()
        {
            return View();
        }

         public IActionResult fiate()
        {
            return View();
        }

         public IActionResult golf()
        {
            return View();
        }

         public IActionResult prius()
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

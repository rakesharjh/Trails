using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Trails.Models;

namespace Trails.Controllers
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

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
         [HttpGet]
        public IActionResult Edit()
        {
            var test = new Test();
            return PartialView("_showAjaxWorks", test);

        }

        [HttpGet]
        public IActionResult ShowEdit()
        {
            var test = new Test();
            return PartialView("_viewAjaxworks",test);
        }
        [HttpPost]
        public IActionResult Edit(int id)
        {
            var test = new Test();
            return PartialView("_viewAjaxworks", test);

        }
    }
}

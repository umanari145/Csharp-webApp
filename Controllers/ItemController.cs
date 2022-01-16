using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("[controller]/[action]")]
    public class ItemController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public ItemController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [Route("/Item/List")]
        public IActionResult GetItemsList()
        {
            _logger.Info("info log.");
            return View();
        }
    }
}

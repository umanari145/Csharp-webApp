using log4net;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;
using WebApplication1.Service;

[assembly: log4net.Config.XmlConfigurator(ConfigFile = "log4net.config", Watch = true)]

namespace WebApplication1.Controllers
{
    [Route("[controller]/[action]")]
    public class ItemController : Controller
    {
        private readonly ILog _logger;

        public ItemController()
        {
            _logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        }

        [Route("/Item/List")]
        public IActionResult GetItemsList()
        {
            MyContext sc = new MyContext();
            sc.addProduct();
            _logger.Info("info log.");
            return View();
        }
    }
}

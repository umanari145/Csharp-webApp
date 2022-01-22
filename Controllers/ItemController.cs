using log4net;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Data;
using WebApplication1.Models;
using WebApplication1.Service;

[assembly: log4net.Config.XmlConfigurator(ConfigFile = "log4net.config", Watch = true)]

namespace WebApplication1.Controllers
{
    [Route("[controller]/[action]")]
    public class ItemController : Controller
    {
        private readonly ILog _logger;

        //private readonly ItemContext _context;
        public ItemController()
        {
            _logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        }

        [Route("/Item/List")]
        public IActionResult GetItemsList()
        {
            _logger.Info("start log.");

            ItemService itemService = new ItemService();
            itemService.GetAllItems();

            return View();
        }
    }
}

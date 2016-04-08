using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace TechOnSite.Controllers
{
    public class ServicesController : Controller
    {
        // GET: /<controller>/
        public IActionResult MalWareRemoval()
        {
            return View();
        }
        public IActionResult Networking()
        {
            return View();
        }
        public IActionResult Data()
        {
            return View();
        }
        public IActionResult Cabling()
        {
            return View();
        }
        public IActionResult LaptopRepair()
        {
            return View();
        }
        public IActionResult DesktopRepair()
        {
            return View();
        }

    }
}

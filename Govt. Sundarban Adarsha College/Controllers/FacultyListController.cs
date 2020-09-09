using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GSAC.Controllers
{
    public class FacultyListController : Controller
    {
        // GET: /<controller>/
        public IActionResult Bangla()
        {
            return View();
        }
        public IActionResult English()
        {
            return View();
        }
        public IActionResult Math()
        {
            return View();
        }

        public IActionResult Chemistry()
        {
            return View();
        }
        public IActionResult Physics()
        {
            return View();
        }
        public IActionResult ICT()
        {
            return View();
        }
        public IActionResult Accounting()
        {
            return View();
        }
        public IActionResult Management()
        {
            return View();
        }
        public IActionResult Economics()
        {
            return View();
        }
        public IActionResult Geography()
        {
            return View();
        }
    }
}

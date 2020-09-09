using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Govt._Sundarban_Adarsha_College.Models;

namespace Govt._Sundarban_Adarsha_College.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

            return View();
        }

        public IActionResult About()
        {
            

            return View();
        }

        public IActionResult Facilities()
        {


            return View();
        }

        public IActionResult Co_Curricular()
        {


            return View();
        }

        public IActionResult Contact()
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
    }
}

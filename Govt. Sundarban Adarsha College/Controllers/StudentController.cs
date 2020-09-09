using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GSAC.Controllers
{
    public class StudentController : Controller
    {
        // GET: /<controller>/

        public IActionResult StudentInformation()
        {
            return View();
        }
        public IActionResult ClassRoutine()
        {
            return View();
        }


        public IActionResult RulesAndRegulation()
        {
            return View();
        }


        public IActionResult AdmissionInformation()
        {


            return View();
        }

        public IActionResult AdmissionGuidelines()
        {


            return View();
        }

        public IActionResult AdmissionContact()
        {


            return View();
        }
        
        public IActionResult Scholarship()
        {


            return View();
        }

 
        public IActionResult Board()
        {


            return View();
        }

        public IActionResult TermOrSemester()
        {


            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using WebApplication66.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication66.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //throw new IndexOutOfRangeException();
            return View();
        }

        //Method for get requests - no parameters (different method signature)
        [HttpGet("GradeCalc")]
        public IActionResult GradeCalc()
        {
            return View();
        }

        //Method for post requests - 
        [HttpPost("GradeCalc")]
        public IActionResult GradeCalc(GradeCalcModel model)
        {
            return View();
        }
    }
}

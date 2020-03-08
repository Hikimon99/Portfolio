using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Kim_InHo_HW2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            // /Home/Index is the home page for your application
            //this action just serves up the index view
            return View();
        }

        [HttpGet]
        public IActionResult Calculate(string strCode, string strTacos, string strSandwiches)
        {

        }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Travel.Controllers
{
    public class CheckoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Confirm()
        {
            return View();

        }
        public IActionResult Failed()
        {
            return View();

        }



    }
}
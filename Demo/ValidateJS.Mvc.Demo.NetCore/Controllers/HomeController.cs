﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ValidateJS.Mvc.NetStandard;

namespace ValidateJS.Mvc.Demo.NetCore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var logger = new AppLogger();
            logger.Log("Hello");
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Tutorials_CoreMVC.Models;

namespace Tutorials_CoreMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Alert()
        {
            return View();
        }

        public IActionResult Link()
        {
            return View();
        }

        public IActionResult Button()
        {
            return View();
        }

        public IActionResult DropDown()
        {
            return View();
        }
        public IActionResult DropDown2()
        {
            return View();
        }
        public IActionResult Form1()
        {
            return View();
        }

        public IActionResult Form2()
        {
            return View();
        }
        public IActionResult Form3()
        {
            return View();
        }

        public IActionResult Spacing()
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

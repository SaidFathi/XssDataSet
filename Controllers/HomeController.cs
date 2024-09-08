﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebscrapingFront.Models;

namespace WebscrapingFront.Controllers
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
            ViewBag.Title = "Welcome XSS Dataset";

            return View();
        }
        // POST: Comment/SubmitComment
        //[HttpPost]
        //public IActionResult SubmitComment(string userName, string comment)
        //{
        //    // Intentionally vulnerable to XSS
        //    ViewBag.UserName = userName;
        //    ViewBag.Comment = comment;

        //    return View();
        //}

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

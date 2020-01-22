﻿using Microsoft.AspNetCore.Mvc;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: /HelloWorld/
        public IActionResult Index()
        {
            return View();
        }

        // GET: /HelloWorld/Welcome/ 
        public IActionResult Welcome(string name, int numTimes = 1)
        {
            string message = "Hello " + name + ".";

            ViewData["Message"] = message;
            ViewData["NumTimes"] = numTimes;

            return View();
        }
    }
}
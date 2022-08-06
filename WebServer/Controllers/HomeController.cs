﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Logging;
using System;
using System.Diagnostics;
using WebServer.Models;

namespace WebServer.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMemoryCache memoryCache;

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, IMemoryCache memoryCache)
        {

            _logger = logger;
            this.memoryCache = memoryCache;
        }

        public IActionResult CourseOne()
        {
            if (!memoryCache.TryGetValue("key_currency", out CurrencyConverter model))
            {
                throw new Exception("Ошибка данных");
            }

            return View(model);
        }
        public IActionResult CourseTwo()
        {
            if (!memoryCache.TryGetValue("key_currency", out CurrencyConverter model))
            {
                throw new Exception("Ошибка данных");
            }

            return View(model);
        }
        public IActionResult CourseThree()
        {
            if (!memoryCache.TryGetValue("key_currency", out CurrencyConverter model))
            {
                throw new Exception("Ошибка данных");
            }

            return View(model);
        }
                public IActionResult CourseFive()
        {
            if (!memoryCache.TryGetValue("key_currency", out CurrencyConverter model))
            {
                throw new Exception("Ошибка данных");
            }

            return View(model);
        }

        public IActionResult CourseFour()
        {
            if (!memoryCache.TryGetValue("key_currency", out CurrencyConverter model))
            {
                throw new Exception("Ошибка данных");
            }

            return View(model);
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

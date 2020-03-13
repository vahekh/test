using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.Logging;
using WebAppR3.Models;

namespace WebAppR3.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IDistributedCache _distributedCache;

        public HomeController(ILogger<HomeController> logger, IDistributedCache distributedCache)
        {
            _logger = logger;
            _distributedCache = distributedCache;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            var cacheKey = "TheTime";
            var existingTime = _distributedCache.GetString(cacheKey);
            if (!string.IsNullOrEmpty(existingTime))
            {
                ViewBag.CacheMessage = "Fetched from cache : " + existingTime;
            }
            else
            {
                existingTime = DateTime.UtcNow.ToString();
                _distributedCache.SetString(cacheKey, existingTime);
                ViewBag.CacheMessage = "Added to cache : " + existingTime;
            }

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

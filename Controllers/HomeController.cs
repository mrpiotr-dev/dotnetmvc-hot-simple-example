using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DotnetHandsontableExample.Models;

namespace DotnetHandsontableExample.Controllers
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

        public JsonResult GetUsers()
        {
          return Json(new Object[] {
            new User(1, "AAAA", "zzzz", "aaaa.zzzz@example.com", true),
            new User(2, "BBBB", "yyyy", "bbbb.yyyy@example.com", true),
            new User(3, "CCCC", "xxxx", "cccc.xxxx@example.com", false),
            new User(4, "DDDD", "wwww", "dddd.wwww@example.com", true),
            new User(5, "EEEE", "vvvv", "eeee.vvvv@example.com", true),
          });
        }

        [HttpPut]
        public JsonResult UpdateUser(int id, [FromBody] object user)
        {
          return Json(new Object[] { id, user });
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

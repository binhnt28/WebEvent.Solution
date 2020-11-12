using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Web.Data.DataContext;
using Web.WebApp.Models;

namespace Web.WebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly DataDbContext _context;
        public HomeController (DataDbContext context)
        {
            _context = context;
        }
        [AllowAnonymous]
        public IActionResult Index()
        {
            ViewBag.ListEvent = _context.Events.ToList();
            return View();
        }

    }
}

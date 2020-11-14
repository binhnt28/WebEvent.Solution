using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Web.Application.MEvent;
using Web.Data.DataContext;
using Web.WebApp.Models;
using Web.WebApp.Service.Event;

namespace Web.WebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly DataDbContext _context;
        private readonly IEventApiClient _eventApiClient;
        public HomeController (DataDbContext context, IEventApiClient eventApiClient)
        {
            _context = context;
            _eventApiClient = eventApiClient;

        }
        [AllowAnonymous]
        public IActionResult Index()
        {
            ViewBag.ListEvent = _context.Events.ToList();
            return View();
        }
        [HttpGet]
        [Route("event/{id}")]
        public async Task<IActionResult> Details(Guid? id)
        {
            var reponse = await _eventApiClient.Details(id);
            var model = JsonConvert.DeserializeObject<EventResponse>(reponse.ToString());
            return View(model);
        }

    }
}

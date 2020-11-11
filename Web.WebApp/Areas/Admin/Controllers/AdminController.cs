using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.WebApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("admin/home")]
    [Route("admin")]
    public class AdminController : Controller
    {
        // GET: HomeController

        [Route("index")]
        [Route("")]
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Create()
        {
            return View();
        }

        // GET: HomeController/Details/5
       
    }
}

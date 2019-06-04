using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using McBonalds.Models;
using Microsoft.AspNetCore.Http;
using McBonalds.Utils;

namespace McBonalds.Controllers
{
    public class HomeController : Controller
    {
        
        [HttpGet]
        public IActionResult Index()
        {
            ViewData["User"] = HttpContext.Session.GetString(Const.SESSION_CLIENTE);
            ViewData["NomeView"] = "Início";
            return View();
        }
    }
}

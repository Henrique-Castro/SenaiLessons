
using Microsoft.AspNetCore.Mvc;

namespace StatePark.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index(){
            return View();
        }
    }
}
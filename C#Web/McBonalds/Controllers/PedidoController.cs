using Microsoft.AspNetCore.Mvc;

namespace McBonalds.Controllers
{
    public class PedidoController : Controller
    {
        public IActionResult Pedidos()
        {
            ViewData["NomeView"] = "Pedidos";
            return View();
        }
    }
}
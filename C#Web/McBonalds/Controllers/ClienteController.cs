using McBonalds.Repositories;
using McBonalds.Utils;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace McBonalds.Controllers
{
    public class ClienteController : Controller
    {
        private ClienteRepository clienteRepository = new ClienteRepository();
        [HttpGet]
        public IActionResult Login (){
            ViewData["NomeView"] = "Login";
            return View();
        }
        [HttpPost]
        public IActionResult Login (IFormCollection form){
            var email = form["email"];
            var senha = form["senha"];
            var cliente = clienteRepository.ObterPor(email);
            if(cliente != null && cliente.Senha.Equals(senha)){
                HttpContext.Session.SetString(Const.SESSION_EMAIL, email);
                HttpContext.Session.SetString(Const.SESSION_CLIENTE, cliente.Nome);
            }
            ViewData["NomeView"] = "Login";
            return RedirectToAction("Index", "Home");
        }
        public IActionResult Logout(){
            HttpContext.Session.Remove(Const.SESSION_CLIENTE);
            HttpContext.Session.Remove(Const.SESSION_EMAIL);
            HttpContext.Session.Clear();

            return RedirectToAction("Index", "Home");
        }
    }
}
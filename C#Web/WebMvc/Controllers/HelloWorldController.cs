using Microsoft.AspNetCore.Mvc;

namespace WebMvc.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Teste(){

            return View();
        }
        public string Welcome(string nome, int idade = 1){
            return $"Seja bem-vindo(a), {nome}!\n Sua idade é {idade}.";
        }
    }
}
using Microsoft.AspNetCore.Mvc;
using WebMvc.Repositorios;

namespace WebMvc.Views.HelloWorld
{
    public class MusicaController : Controller
    {
        public IActionResult Index(){
            return View();
        }
        public IActionResult Playlist(string nome, int vezes = 1){
            ViewData["Nome"] = nome;
            return View(MusicaRepositorio.Musicas);
        }
    }
}
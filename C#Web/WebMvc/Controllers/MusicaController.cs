using Microsoft.AspNetCore.Mvc;
namespace WebMvc.Views.HelloWorld
{
    public class MusicaController : Controller
    {
        public IActionResult Index(){
            return View();
        }
        public IActionResult Playlist(string nome, int vezes = 1){
            ViewData["Nome"] = nome;
            ViewData["Vezes"] = vezes;
            ViewData["NomesRepetidos"] = "";
            for(int i = 0; i < vezes;i++){
                @ViewData["NomesRepetidos"] += nome + "\n";
            }
            return View();
        }
    }
}
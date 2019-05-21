using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebEx2.Models;
using WebEx2.Repositories;

namespace WebEx2.Controllers
{
    public class UsuarioController : Controller 
    {
        [HttpGet]
        public IActionResult Index(){
            ViewData["Titulo"] = "WebEx2";
            return View();
        }
        [HttpPost]
        public IActionResult CadastrarUsuario(IFormCollection form){
            UsuarioRepositorio repository = new UsuarioRepositorio();
            var usuario = new UsuarioModel(
                name: form["name"],
                password: form["password"],
                birthDate: DateTime.Parse(form["date"]),
                email: form["email"]
            );
            repository.Cadastrar(usuario);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult ListarUsuarios(){
            UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio();
            ViewData["usuarios"] = usuarioRepositorio.Listar();
            return View();
        }
    }
}
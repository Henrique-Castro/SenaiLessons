using System;
using System.Collections.Generic;
using Ex2WebMVC.Models;
using Ex2WebMVC.Repositorio;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ex2WebMVC.Controllers
{
 
    public class UsuarioController : Controller
    {
        [HttpGet]
        public IActionResult Index(){

            return View();
        }
        [HttpPost]
        public IActionResult Cadastrar(IFormCollection form){
            UsuarioModel usuario = new UsuarioModel(
                nome: form["nome"],
                email: form["email"],
                dataNascimento: DateTime.Parse(form["dataNascimento"]),
                senha: form["senha"]
            );

            UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio();
            usuarioRepositorio.CadastrarUsuario(usuario);
            
            return RedirectToAction("Index","Usuario");
        }

        [HttpGet]
        public IActionResult Listar(){
            UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio();
            ViewData["usuarios"] = usuarioRepositorio.Listar();

            return View();
        }
        [HttpGet]
        public IActionResult Editar(int id){
            UsuarioRepositorio repositorio = new UsuarioRepositorio();
            UsuarioModel usuarioRecuperado =  repositorio.BuscarPorId(id);
            if(usuarioRecuperado != null){
                ViewBag.Usuario = usuarioRecuperado;
            }else{
                TempData["Mensagem"] = "Usuario não encontrado";
                return RedirectToAction("Listar");
            }
            return View();
        }

        [HttpPost]
        public IActionResult Editar(IFormCollection form){
            UsuarioModel usuario = new UsuarioModel(
                id:int.Parse(form["id"]),
                nome:form["nome"],
                email:form["email"],
                dataNascimento:DateTime.Parse(form["dataNascimento"]),
                senha:form["senha"]
            );
            UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio();
            usuarioRepositorio.EditarUsuario(usuario);
            TempData["mensagem"] = $"{usuario.Nome} editado com sucesso.";
            return RedirectToAction("Listar");
        }
    }
}
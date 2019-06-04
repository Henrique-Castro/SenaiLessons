using System;
using McBonalds.Models;
using McBonalds.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace McBonalds.Controllers
{
    public class Cadastro : Controller
    {
        ClienteRepository clienteRepository = new ClienteRepository();
        public IActionResult Index(){
            ViewData["NomeView"] = "Cadastro";
            return View();
        }
        public IActionResult Cadastrar(IFormCollection form){
            var cliente = new Cliente(
                nome:form["nome"],
                endereco:form["endereco"],
                telefone:form["telefone"],
                email:form["email"],
                senha:form["senha"],
                dataNascimento:form["dataNascimento"]
            );
            clienteRepository.Inserir(cliente);
            ViewData["Action"] = "Cadastro";
            return View("Sucesso");
        }
    }
}
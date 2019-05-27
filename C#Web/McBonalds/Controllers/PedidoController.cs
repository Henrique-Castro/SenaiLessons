using System;
using McBonalds.Models;
using McBonalds.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using McBonalds.ViewModels;

namespace McBonalds.Controllers
{
    public class PedidoController : Controller
    {
        [HttpGet]
        public IActionResult Pedidos()
        {
            ViewData["NomeView"] = "Pedidos";
            var listaDeHamburgueres = HamburguerRepository.Listar();
            var listaDeShakes = ShakeRepository.Listar();
            Pedido pedido = new Pedido(
                listaDeHamburgueres: listaDeHamburgueres,
                listaDeShakes:listaDeShakes
            );

            return View(pedido);
        }
        [HttpPost]
        public IActionResult RegistrarPedido(IFormCollection form){
            
            var cliente = new Cliente(
                nome: form["nome"],
                endereco:form["endereco"],
                telefone:form["telefone"],
                email:form["email"]
            );
            
            var hamburguer = new Hamburguer(
                nome:form["hamburguer"],
                preco:HamburguerRepository.ObterPrecoDe(form["hamburguer"]),
                id:HamburguerRepository.ObterIdDe(form["hamburguer"])
            );
            var shake = new Shake(
                nome:form["shake"],
                preco:ShakeRepository.ObterPrecoDe(form["shake"]),
                id:ShakeRepository.ObterIdDe(form["shake"])
            );
            var pedido = new Pedido(
                cliente: cliente,
                hamburguer:hamburguer,
                shake: shake,
                dataPedido: DateTime.Now
            );
            pedido.PrecoTotal = hamburguer.Preco + shake.Preco;
            PedidoRepository.GravarPedido(pedido);
            ViewData["Funcao"] = "Pedido";
            return View("Sucesso");
        }
    }
}
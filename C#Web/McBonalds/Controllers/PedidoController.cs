using System;
using McBonalds.Models;
using McBonalds.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace McBonalds.Controllers
{
    public class PedidoController : Controller
    {
        [HttpGet]
        public IActionResult Pedidos()
        {
            ViewData["NomeView"] = "Pedidos";
            return View();
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
                nome:form["hamburguer"]
            );
            var shake = new Shake(
                nome:form["shake"]
            );

            var pedido = new Pedido(
                cliente: cliente,
                hamburguer:hamburguer,
                shake: shake,
                dataPedido: DateTime.Now
            );
            PedidoRepository.GravarPedido(pedido);
            ViewBag.Alerta = true;
            return RedirectToAction("Index", "Home");
        }
    }
}
using System;
using System.Reflection.Metadata;
using McBonalds.Models;
using McBonalds.Repositories;
using McBonalds.Utils;
using McBonalds.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace McBonalds.Controllers {
    public class PedidoController : Controller {
        private ClienteRepository clienteRepository = new ClienteRepository ();
        [HttpGet]
        public IActionResult Pedidos () {
            ViewData["NomeView"] = "Pedidos";
            var listaDeHamburgueres = HamburguerRepository.Listar ();
            var listaDeShakes = ShakeRepository.Listar ();
            var cliente = clienteRepository.ObterPor (HttpContext.Session.GetString (Const.SESSION_EMAIL));
            if(cliente == null){
                cliente = new Cliente();
                cliente.Nome = "jovem";
            }
            Pedido pedido = new Pedido (
                listaDeHamburgueres: listaDeHamburgueres,
                listaDeShakes: listaDeShakes,
                cliente: cliente
            );

            return View (pedido);
        }

        [HttpPost]
        public IActionResult RegistrarPedido (IFormCollection form) {
            var cliente = clienteRepository.ObterPor (HttpContext.Session.GetString (Const.SESSION_EMAIL));
            if (cliente.Email == null) {
                cliente = new Cliente (
                    nome: form["nome"],
                    email: form["email"],
                    endereco: form["endereco"],
                    telefone: form["telefone"]
                );
            }
            var hamburguer = new Hamburguer (
                nome: form["hamburguer"],
                preco: HamburguerRepository.ObterPrecoDe (form["hamburguer"]),
                id: HamburguerRepository.ObterIdDe (form["hamburguer"])
            );
            var shake = new Shake (
                nome: form["shake"],
                preco: ShakeRepository.ObterPrecoDe (form["shake"]),
                id: ShakeRepository.ObterIdDe (form["shake"])
            );
            var pedido = new Pedido (
                cliente: cliente,
                hamburguer: hamburguer,
                shake: shake,
                dataPedido: DateTime.Now
            );
            PedidoRepository pedidoRepository = new PedidoRepository ();
            pedido.PrecoTotal = hamburguer.Preco + shake.Preco;
            pedidoRepository.Inserir (pedido);
            return View ("Sucesso");
        }
    }
}
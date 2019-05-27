using System;
using System.Collections.Generic;
using McBonalds.Models;

namespace McBonalds.ViewModels {
    public class Pedido {
        public ulong Id { get; set; }
        public Cliente Cliente { get; set; }
        public Hamburguer Hamburguer { get; set; }
        public Shake Shake { get; set; }
        public DateTime DataPedido { get; set; }
        public List<Hamburguer> ListaDeHamburgueres{get;set;}
        public List<Shake> ListaDeShakes{get;set;}
        public float PrecoTotal{get;set;}
        public Pedido () {

        }
        public Pedido (Cliente cliente, Hamburguer hamburguer, Shake shake, DateTime dataPedido) {
            Cliente = cliente;
            Hamburguer = hamburguer;
            Shake = shake;
            DataPedido = dataPedido;
        }
        public Pedido (ulong id, Cliente cliente, Hamburguer hamburguer, Shake shake, DateTime dataPedido) {
            Cliente = cliente;
            Hamburguer = hamburguer;
            Shake = shake;
            DataPedido = dataPedido;
        }
        public Pedido (List<Hamburguer> listaDeHamburgueres, List<Shake> listaDeShakes){
            ListaDeHamburgueres = listaDeHamburgueres;
            ListaDeShakes = listaDeShakes;
        }

    }
}
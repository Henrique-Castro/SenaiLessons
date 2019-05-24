using System;
namespace McBonalds.Models {
    public class Pedido {
        public ulong Id { get; set; }
        public Cliente Cliente { get; set; }
        public Hamburguer Hamburguer { get; set; }
        public Shake Shake { get; set; }

        public DateTime DataPedido { get; set; }
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

    }
}
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Sockets;
using McBonalds.Models;
using McBonalds.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace McBonalds.Repositories {
    public class PedidoRepository : DbContext {
        private static List<Pedido> ListaDePedidos = new List<Pedido> ();
        private const string PATH = "Database/Pedidos.csv";
        public static bool GravarPedido (Pedido pedido) {
            try {
                ulong idPedido;
                if (!File.Exists (PATH)) {
                    File.Create (PATH).Close ();
                }
                if (ListarPedidos () == null) {
                    idPedido = 1;
                } else {
                    idPedido = (UInt64) ListarPedidos ().Count + 1;
                }
                var registro = $"{idPedido};{pedido.Cliente.Nome};{pedido.Cliente.Endereco};{pedido.Cliente.Telefone};{pedido.Cliente.Email};{pedido.Hamburguer.Nome};{pedido.Shake.Nome};{pedido.PrecoTotal};{pedido.DataPedido}\n";

                File.AppendAllText (PATH, registro);
            } catch (Exception e) {
                System.Console.WriteLine ("Chegou no catch!");
                System.Console.WriteLine (e.Message);
            }

            return true;
        }
        public static List<Pedido> ListarPedidos () {
            ListaDePedidos.Clear ();
            if (!File.Exists ("Pedidos.csv")) {
                return null;
            }
            string[] listaNaoTratada = File.ReadAllLines (PATH);
            foreach (string linha in listaNaoTratada) {
                if (linha != null) {
                    string[] dados = linha.Split (";");
                    var cliente = new Cliente (
                        nome: dados[1],
                        endereco: dados[2],
                        telefone: dados[3],
                        email: dados[4]
                    );
                    var hamburguer = new Hamburguer (
                        nome: dados[5]
                    );
                    var shake = new Shake (
                        nome: dados[6]
                    );
                    var pedido = new Pedido (
                        id: ulong.Parse (dados[0]),
                        cliente: cliente,
                        hamburguer: hamburguer,
                        shake: shake,
                        dataPedido: DateTime.Parse (dados[7])
                    );
                    ListaDePedidos.Add (pedido);
                }
            }
            return ListaDePedidos;
        }
        public static Pedido BuscarPedido (Pedido pedido) {
            ListaDePedidos = ListarPedidos();
            foreach (var item in ListaDePedidos)
            {
                if(item.Id == pedido.Id && item != null){
                    return item;
                }
            }
            return null;
            
        }
    }
}
using System;
using PadariaMVC.ViewModel;

namespace PadariaMVC {
    class Program {
        static void Main (string[] args) {
            UsuarioViewModel usuario = new UsuarioViewModel ();
            usuario.Id = 1;
            usuario.Nome = "Henrique";
            usuario.DataCriacao = DateTime.Now;

            ProdutoViewModel produto = new ProdutoViewModel ();
            produto.Id = 1;
            produto.Nome = "Pão";

        }
    }
}
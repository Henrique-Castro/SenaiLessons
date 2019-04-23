using System;
using System.Linq;

namespace desafioPizzaria {
    class Program {
        static void Main (string[] args) {
            Usuario[] arrayUsuarios = new Usuario[5];
            Usuario u = new Usuario ();
            string[] menu = {
                "1- Cadastro de usuário",
                "2- Efetuar login",
                "3- Listar usuários",
                "9- Sair"
            };
            bool e = true;
            while (e == true) {
                foreach (string linha in menu) {
                    System.Console.WriteLine (linha);
                }
                switch (Console.ReadLine ()) {
                    case "1":
                        Usuario.Inserir ();
                        continue;
                    case "2":

                        Usuario.EfetuarLogin ();
                        continue;

                    case "3":
                        Usuario.Listar ();
                        continue;
                    case "9":
                        e = false;
                        break;
                }
            }

        }
    }
}
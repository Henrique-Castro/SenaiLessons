using System;
using System.Linq;

namespace desafioPizzaria {
    class Program {
        static void Main (string[] args) {
            Usuario[] arrayUsuarios = new Usuario[5];
            Usuario u = new Usuario ();
            string[] menu = {
                "=======================================",
                "||             M E N U               ||",
                "||       1- Cadastrar usuário        ||",
                "||       2- Fazer login              ||",
                "||       3- Listar usuários          ||",
                "||       9- Sair                     ||",
                "======================================="
            };
            string[] menuLogado = {
                "=======================================",
                "||             M E N U               ||",
                "||       1- Cadastrar usuário        ||",
                "||       2- Cardápio                 ||",
                "||       3- Listar usuários          ||",
                "||       9- Sair                     ||",
                "======================================="
            };
            string[] cardapio = {
                "=======================================",
                "||          C A R D Á P I O          ||",
                "||       1- Cadastrar produto        ||",
                "||       2- Buscar por ID            ||",
                "||       3- Listar produtos          ||",
                "||       9- Sair                     ||",
                "======================================="
            };
            bool e = true;
            while (e == true) {
                menuPrincipal : if (Usuario.logado == false) {
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
                } else if (Usuario.logado == true) { //CASO O USUÁRIO JÁ ESTEJA LOGADO: 
                    foreach (string linha in menuLogado) {
                        System.Console.WriteLine (linha);
                    }
                    switch (Console.ReadLine ()) {
                        case "1":
                            Usuario.Inserir ();
                            continue;
                        case "2":

                            foreach (string linha in cardapio) {
                                System.Console.WriteLine (linha);
                            }
                            switch (Console.ReadLine ()) { //NAVEGAÇÃO PELO CARDÁPIO
                                case "1":
                                    //CADASTRAR PRODUTO
                                    Produto.CadastrarProduto ();
                                    continue;
                                case "2":
                                    //BUSCAR POR ID
                                    System.Console.WriteLine (Produto.BuscarPorId ());
                                    System.Console.WriteLine ("\nAperte ENTER para voltar ao menu");
                                    Console.ReadLine ();
                                    continue;

                                case "3":
                                    //LISTAR PRODUTOS
                                    Produto.ListarProdutos ();
                                    continue;
                                case "9":
                                    goto menuPrincipal;

                            }
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
}
using System;
using PadariaMVC.Utils;
using PadariaMVC.ViewController;
using PadariaMVC.ViewModel;

namespace PadariaMVC {
    class Program {
        static void Main (string[] args) {

            do {
                MenuUtils.MostrarMenuDeslogado ();
                MenuDeslogadoEnum opcao = ((MenuDeslogadoEnum) Enum.Parse (typeof (MenuDeslogadoEnum), Console.ReadLine ()));
                    switch (opcao) {
                        case MenuDeslogadoEnum.CADASTRAR_USUARIO:
                            //Cadastrar usuário
                            UsuarioViewController.CadastrarUsuario();
                            break;
                        case MenuDeslogadoEnum.EFETUAR_LOGIN:
                            //Efetuar Login
                            UsuarioViewModel usuarioLogado = UsuarioViewController.EfetuarLogin();
                            do{
                                //Colocar o menu logado
                            }while(usuarioLogado != null);
                            break;
                        case MenuDeslogadoEnum.LISTAR_USUARIOS:
                            //Listar usuários cadastrados
                            UsuarioViewController.ListarUsuarios();
                            break;
                        case MenuDeslogadoEnum.SAIR:
                            //Sair
                            Environment.Exit(0);
                            break;
                        default:
                            break;
                    }

                }
                while (true);
            }

        }
    }
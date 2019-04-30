using System;
using PadariaMVC.Utils;
using PadariaMVC.Utils.Enums;
using PadariaMVC.ViewController;
using PadariaMVC.ViewModel;

namespace PadariaMVC {
    class Program {
        static void Main (string[] args) {
            UsuarioViewModel usuarioLogado = null;
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
                            
                            usuarioLogado = UsuarioViewController.EfetuarLogin();
                            
                            do{
                                //Menu logado
                                MenuUtils.MostrarMenuLogado(usuarioLogado);
                                MenuLogadoEnum opcaoLogado = ((MenuLogadoEnum) Enum.Parse (typeof (MenuLogadoEnum), Console.ReadLine ()));
                                switch(opcaoLogado){
                                    case MenuLogadoEnum.CADASTRAR_PRODUTO:
                                    //TODO: CadastrarProduto()
                                    ProdutoViewController.CadastrarProduto();
                                    break;
                                    case MenuLogadoEnum.ALTERAR_PRODUTO:
                                    //TODO: AlterarProduto()
                                    break;
                                    case MenuLogadoEnum.LISTAR:
                                    //TODO: Listar()
                                    ProdutoViewController.ListarProdutos();
                                    break;
                                    case MenuLogadoEnum.REMOVER_PRODUTO:
                                    //TODO: RemoverProduto()
                                    ProdutoViewController.RemoverProduto();
                                    break;
                                    case MenuLogadoEnum.VALOR_TOTAL:
                                    //TODO: ValorTotal()
                                    break;
                                    case MenuLogadoEnum.VOLTAR:
                                    usuarioLogado = null;
                                    break;
                                }
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
                        Mensagem.MostrarMensagem("Digite uma opção válida.", TipoMensagemEnum.ERRO);
                            break;
                    }

                }
                while (true);
            }
            public void Sair(){
                Environment.Exit(0);
            }
        }
    }
using System;
using ToDoList.ControllerView;
using ToDoList.Utils;
using ToDoList.Utils.Enums;

namespace ToDoList
{
    class Program
    {
        static void Main(string[] args)
        {
            
            MenuUtils.MostrarMenuInicial();
            MenuInicialEnum opcaoInicial = (MenuInicialEnum)Enum.Parse(typeof(MenuInicialEnum), Console.ReadLine());
            switch (opcaoInicial)
            {
                case MenuInicialEnum.CADASTRAR:
                    //Cadastrar usuário
                    UsuarioControllerView.CadastrarUsuario();
                break;
                case MenuInicialEnum.LOGIN:
                    //Efetuar Login
                    if(UsuarioControllerView.EfetuarLogin() == true){
                        Mensagem.MostrarMensagem("Opre", TipoMensagemEnum.SUCESSO);
                    }
                break;
                case MenuInicialEnum.SAIR:
                    Environment.Exit(0);
                break;
                default:
                break;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using PadariaMVC.Repository;
using PadariaMVC.Utils;
using PadariaMVC.Utils.Enums;
using PadariaMVC.ViewModel;
using PadariaMVC.ViewController;

namespace PadariaMVC.ViewController {
    public class UsuarioViewController {
        //Instanciar o repositorio
        static UsuarioRepository usuarioRepository = new UsuarioRepository ();
        //Instanciar o objeto
        static UsuarioViewModel usuarioViewModel;
        ///<summary>Cadastra o usuário com os atributos nome, email e senha, fazendo os devidos testes em cima das entradas do usuário.</summary>
        public static void CadastrarUsuario () {
            string nome, email, senha, confirmacaoSenha;
            do {
                System.Console.Write ("Nome do usuário: ");
                nome = Console.ReadLine ();
                if (ValidacaoUtil.ValidarNome (nome) == false) {
                    Mensagem.MostrarMensagem("Nome inválido", TipoMensagemEnum.ERRO);
                }

            } while (ValidacaoUtil.ValidarNome (nome) == false);

            do {
                System.Console.Write ("Email: ");
                email = Console.ReadLine ();
                if (ValidacaoUtil.ValidarEmail (email) == false) {
                    Mensagem.MostrarMensagem("Email inválido", TipoMensagemEnum.ERRO);
                }

            } while (ValidacaoUtil.ValidarEmail (email) == false);

            do {
                System.Console.Write ("Senha: ");
                senha = Console.ReadLine ();
                System.Console.Write ("Confirme a senha: ");
                confirmacaoSenha = Console.ReadLine ();
                if (ValidacaoUtil.ValidarSenha (senha, confirmacaoSenha) == false) {
                    System.Console.WriteLine ("Insira novamente.");
                }

                usuarioViewModel = new UsuarioViewModel(nome, email, senha);

                //Inserir o Objeto criado para armazenamento
                usuarioRepository.InserirUsuario (usuarioViewModel);

                Mensagem.MostrarMensagem("Usuário cadastrado com sucesso!", TipoMensagemEnum.SUCESSO);
            } while (ValidacaoUtil.ValidarSenha (senha, confirmacaoSenha) == false);

        }
        ///<summary>Lista todos os usuários previamente cadastrados, exibindo seus atributos: Id, Nome, Email, Senha e Data de Criação</summary>
        public static void ListarUsuarios () {
            List<UsuarioViewModel> listaDeUsuarios = usuarioRepository.ListarUsuarios ();

            foreach (var item in listaDeUsuarios) {
                System.Console.WriteLine ($"---------------------------\nId: {item.Id}\nNome: {item.Nome}\nEmail: {item.Email} \nSenha: {item.Senha}\nData de criação: {item.DataCriacao}\n---------------------------");
            }
        }
        ///<summary>Recebe as informações inseridas pelo usuário para o login e efetua as validações necessárias com os dados de usuários cadastrados</summary>
        ///<returns>Caso as validações sejam aprovadas, retorna um objeto do tipo UsuarioViewModel.false Caso as validações não sejam aprovadas, retorna nulo.</returns>
        public static UsuarioViewModel EfetuarLogin () {
            string email, senha;
            do {
                System.Console.Write ("Email: ");
                email = Console.ReadLine ();
                if (!ValidacaoUtil.ValidarEmail (email)) {
                    Mensagem.MostrarMensagem("Email inválido", TipoMensagemEnum.ERRO);
                }
            } while (ValidacaoUtil.ValidarEmail (email) == false);
            System.Console.Write ("Senha: ");
            senha = Console.ReadLine ();

            UsuarioViewModel usuarioRetornado = usuarioRepository.BuscarUsuario (email, senha);
            if (usuarioRetornado != null) {
                return usuarioRetornado;
            } else {
                Mensagem.MostrarMensagem($"Usuario ou senha inválidos", TipoMensagemEnum.ALERTA);
                return usuarioRetornado;
            }

        }

    }
}
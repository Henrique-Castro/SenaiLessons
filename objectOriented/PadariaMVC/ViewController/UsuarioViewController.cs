using System;
using System.Collections.Generic;
using PadariaMVC.Repository;
using PadariaMVC.Utils;
using PadariaMVC.ViewModel;

namespace PadariaMVC.ViewController {
    public class UsuarioViewController {
        //Instanciar o repositorio
        static UsuarioRepository usuarioRepository = new UsuarioRepository ();
        //Instanciar o objeto
        static UsuarioViewModel usuarioViewModel = new UsuarioViewModel ();
        public static void CadastrarUsuario () {
            string nome, email, senha, confirmacaoSenha;
            do {
                System.Console.Write ("Nome do usuário: ");
                nome = Console.ReadLine ();
                if (ValidacaoUtil.ValidarNomeUsuario (nome) == false) {
                    System.Console.WriteLine ("Nome inválido");
                }

            } while (ValidacaoUtil.ValidarNomeUsuario (nome) == false);

            do {
                System.Console.Write ("Email: ");
                email = Console.ReadLine ();
                if (ValidacaoUtil.ValidarEmail (email) == false) {
                    System.Console.WriteLine ("Email inválido.");
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

                usuarioViewModel.Usuario (nome, email, senha);

                //Inserir o Objeto criado para armazenamento
                usuarioRepository.Inserir (usuarioViewModel);

            } while (ValidacaoUtil.ValidarSenha (senha, confirmacaoSenha) == false);

        }

        public static void ListarUsuarios () {
            List<UsuarioViewModel> listaDeUsuarios = usuarioRepository.Listar ();

            foreach (var item in listaDeUsuarios) {
                System.Console.WriteLine ($"---------------------------\nId: {item.Id}\nNome: {item.Nome}\nEmail: {item.Email} \nSenha: {item.Senha}\nData de criação: {item.DataCriacao}\n---------------------------");
            }
        }
        public static UsuarioViewModel EfetuarLogin () {
            string email, senha;
            do {
                System.Console.Write ("Email: ");
                email = Console.ReadLine ();
                if (!ValidacaoUtil.ValidarEmail (email)) {
                    System.Console.WriteLine ("Email inválido");
                }
            } while (ValidacaoUtil.ValidarEmail (email) == false);
            System.Console.Write ("Senha: ");
            senha = Console.ReadLine ();

            UsuarioViewModel usuarioRetornado = usuarioRepository.BuscarUsuario (email, senha);
            if (usuarioRetornado != null) {
                return usuarioRetornado;
            } else {
                System.Console.WriteLine ($"Usuario ou senha inválidos");
                return usuarioRetornado;
            }

        }

    }
}
using System;
using System.ComponentModel.DataAnnotations;
using ToDoList.ModelView;
using ToDoList.Repository;
using ToDoList.Utils;
using ToDoList.Utils.Enums;

namespace ToDoList.ControllerView {
    public class UsuarioControllerView : UsuarioModelView {
        public static UsuarioModelView usuarioModelView;
        public static UsuarioRepository repository;

        ///<summary>Pede todas as informações para o usuário, recolhe e as insere no armazenamento. </summary>
        public static void CadastrarUsuario () {
            string nome, email, senha, tipo;
            //RECEBE E TESTA NOME DE USUÁRIO
            do {
                System.Console.Write ("Nome de usuário: ");
                nome = Console.ReadLine ();
                if (!ValidacoesUtils.ValidarStringVazia (nome)) {
                    Mensagem.MostrarMensagem ("O nome não pode ficar vazio.", TipoMensagemEnum.ALERTA);
                }
            } while (!ValidacoesUtils.ValidarStringVazia (nome));
            //RECEBE E TESTA EMAIL
            do {
                System.Console.Write ("Email: ");
                email = Console.ReadLine ();
                if (!ValidacoesUtils.ValidarEmail (email)) {
                    Mensagem.MostrarMensagem ("O email não possui um formato válido.", TipoMensagemEnum.ALERTA);
                }
            } while (!ValidacoesUtils.ValidarEmail (email));
            //RECEBE E TESTA SENHA
            do {
                System.Console.WriteLine ("Senha: ");
                senha = Console.ReadLine ();
                if (!ValidacoesUtils.ValidarSenha (senha)) {
                    Mensagem.MostrarMensagem ("A senha não pode ter menos de 8 caracteres nem mais do que 32.", TipoMensagemEnum.ALERTA);
                }
            } while (!ValidacoesUtils.ValidarSenha (senha));
            //RECEBE O TIPO DE USUÁRIO
            do {
                MenuUtils.MostrarMenuTipoUsuario ();
                MenuTipoUsuário opcaoTipoUsuario = (MenuTipoUsuário) Enum.Parse (typeof (MenuTipoUsuário), Console.ReadLine ());                
                if (ValidacoesUtils.ValidarTipoUsuario (opcaoTipoUsuario) == null) {
                    Mensagem.MostrarMensagem ("Por favor, digite um número adequado.", TipoMensagemEnum.ALERTA);
                    tipo = null;
                    continue;
                } else {
                    tipo = ValidacoesUtils.ValidarTipoUsuario (opcaoTipoUsuario);
                }
            } while (tipo == null);

            usuarioModelView = new UsuarioModelView (nome, email, senha, tipo);
            repository.InserirUsuario (usuarioModelView);
            Mensagem.MostrarMensagem ("Usuário cadastrado com sucesso!", TipoMensagemEnum.SUCESSO);
        }

        public static bool EfetuarLogin () {
            string email, senha;
            do {
                do {
                    System.Console.Write ("Email:");
                    email = Console.ReadLine ();
                    if(!ValidacoesUtils.ValidarEmail(email)){
                        Mensagem.MostrarMensagem("Email não possui caracteres necessários ( @ ou . )", TipoMensagemEnum.ALERTA);
                    }
                } while (!ValidacoesUtils.ValidarEmail(email));
                do{
                    System.Console.Write("Senha: ");
                    senha = Console.ReadLine();
                    if(!ValidacoesUtils.ValidarSenha(senha)){
                        Mensagem.MostrarMensagem("Senha com tamanho inválido.", TipoMensagemEnum.ALERTA);
                    }
                }while(!ValidacoesUtils.ValidarSenha(senha));
                if(!ValidacoesUtils.ValidarLogin(email, senha)){
                    Mensagem.MostrarMensagem("Email ou senha inválidos.", TipoMensagemEnum.ERRO);
                    return false;
                }else{
                    return true;
                }
            }while(!ValidacoesUtils.ValidarLogin(email, senha));
        }

    }
}
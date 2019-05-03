using System;
using System.ComponentModel.DataAnnotations;
using ToDoList.ModelView;
using ToDoList.Repository;
using ToDoList.Util;
using ToDoList.Utils;
using ToDoList.Utils.Enums;

namespace ToDoList.ControllerView {
    public class UsuarioControllerView : UsuarioModelView {
        public static UsuarioModelView usuarioModelView;
        public static UsuarioRepository repository = new UsuarioRepository();

        ///<summary>Pede todas as informações para o usuário, recolhe e as insere no armazenamento. </summary>
        public static void CadastrarUsuario () {
            string nome, email, senha, tipo = null, confirm;
            //RECEBE E TESTA NOME DE USUÁRIO
            do {
                System.Console.Write ("Nome de usuário: ");
                nome = Console.ReadLine ();
                if (!ValidacaoUtil.ValidarStringVazia (nome)) {
                    Mensagem.MostrarMensagem ("O nome não pode ficar vazio.", TipoMensagemEnum.ALERTA);
                }
            } while (!ValidacaoUtil.ValidarStringVazia (nome));
            //RECEBE E TESTA EMAIL
            do {
                System.Console.Write ("Email: ");
                email = Console.ReadLine ();
                if (!ValidacaoUtil.ValidarEmail (email)) {
                    Mensagem.MostrarMensagem ("O email não possui um formato válido.", TipoMensagemEnum.ALERTA);
                }
            } while (!ValidacaoUtil.ValidarEmail (email));
            //RECEBE E TESTA SENHA
            do {
                System.Console.Write ("Senha: ");
                senha = Console.ReadLine ();
                System.Console.Write("Confirme a senha: ");
                confirm = Console.ReadLine();
                
                if (!ValidacaoUtil.ValidarSenha (senha, confirm)) {
                    Mensagem.MostrarMensagem ("A senha não pode ter menos de 8 caracteres nem mais do que 32.", TipoMensagemEnum.ALERTA);
                }
            } while (!ValidacaoUtil.ValidarSenha (senha, confirm));
            //RECEBE O TIPO DE USUÁRIO
            do {
                MenuUtils.MostrarMenuTipoUsuario ();
                MenuTipoUsuário opcaoTipoUsuario = (MenuTipoUsuário) Enum.Parse (typeof (MenuTipoUsuário), Console.ReadLine ());                
                if (ValidacaoUtil.ValidarTipoUsuario (opcaoTipoUsuario) == null) {
                    Mensagem.MostrarMensagem ("Por favor, digite um número adequado.", TipoMensagemEnum.ALERTA);
                    continue;
                } else {
                    tipo = ValidacaoUtil.ValidarTipoUsuario (opcaoTipoUsuario);
                }
            } while (tipo == null);
            
            usuarioModelView = new UsuarioModelView(nome, email, senha, tipo);
            repository.InserirUsuario(usuarioModelView);
            Mensagem.MostrarMensagem ("Usuário cadastrado com sucesso!", TipoMensagemEnum.SUCESSO);
        }

        public static bool EfetuarLogin () {
            string email, senha;
            do {
                do {
                    System.Console.Write ("Email:");
                    email = Console.ReadLine ();
                    if(!ValidacaoUtil.ValidarEmail(email)){
                        Mensagem.MostrarMensagem("Email não possui caracteres necessários ( @ ou . )", TipoMensagemEnum.ALERTA);
                    }
                } while (!ValidacaoUtil.ValidarEmail(email));
                do{
                    System.Console.Write("Senha: ");
                    senha = Console.ReadLine();
                    
                }while(senha != null && senha != " ");
                if(!ValidacaoUtil.ValidarLogin(email, senha)){
                    Mensagem.MostrarMensagem("Email ou senha inválidos.", TipoMensagemEnum.ERRO);
                    return false;
                }else{
                    return true;
                }
            }while(!ValidacaoUtil.ValidarLogin(email, senha));
        }

    }
}
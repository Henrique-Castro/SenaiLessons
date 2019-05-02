using System;
using ToDoList.ModelView;
using ToDoList.Repository;
using ToDoList.Utils.Enums;

namespace ToDoList.Utils {
    public class ValidacoesUtils {
        ///<summary>Valida se a string passada no argumento está vazia ou não.</summary>
        ///<param name="palavra">String a ser examinada</param>
        ///<returns>Retorna 'true' caso a string não esteja vazia e 'false' caso seja uma string vazia</returns>
        public static bool ValidarStringVazia (string palavra) {
            if (palavra.Equals ("") || palavra == null) {
                return false;
            } else {
                return true;
            }
        }

        ///<summary>Valida se o email passado no argumento contém '@' e '.' .</summary>
        ///<param name="email">Email do usuário</param>
        ///<returns>Retorna 'true' caso o email contenha '@' e '.' e retorna 'false' no caso contrário.</returns>
        public static bool ValidarEmail (string email) {
            if (email.Contains ("@") && email.Contains (".")) {
                return true;
            } else {
                return false;
            }
        }

        ///<summary>Valida se a senha passada no argumento possui 8 caracteres ou mais e menos de 32.</summary>
        ///<param name="senha">Senha do usuário</param>
        ///<returns>Retorna 'true' caso a senha possua 8 caracteres ou mais e menos de 32, e retorna 'false' no caso contrário.</returns>
        public static bool ValidarSenha (string senha) {
            if (senha.Length >= 8 && senha.Length <= 32) {
                return true;
            } else {
                return false;
            }
        }
        ///<summary>Valida se o tipo de usuário será Usuário ou Administrador.</summary>
        ///<returns>Retorna a string 'Usuário' caso a pessoa tenha selecionado e 'Administrador' caso a pessoa tenha selecionado e null no caso contrário.</returns>
        public static string ValidarTipoUsuario (MenuTipoUsuário opcaoTipoUsuario) {
            // MenuTipoUsuário opcaoTipoUsuario = (MenuTipoUsuário) Enum.Parse (typeof (MenuTipoUsuário), Console.ReadLine ());
            switch (opcaoTipoUsuario) {
                case MenuTipoUsuário.USUARIO:
                    return "Usuário";
                case MenuTipoUsuário.ADMINISTRADOR:
                    return "Administrador";
                default:
                    
                    return null;
            }
        }
        ///<summary>Valida se o email e a senha digitadas pelo usuário correspondem ao email e a senha de algum usuário já existente.</summary>
        ///<param name="email">Email do usuário</param>
        ///<param name="senha">Senha do usuário</param>
        ///<returns>Retorna 'true' caso a senha e o email tenham sido encontrados em algum usuário existente, e retorna 'false' no caso contrário.</returns>
        public static bool ValidarLogin(string email, string senha){
            UsuarioModelView usuario = UsuarioRepository.BuscarUsuarioPorEmail(email);
            if(usuario == null){
                return false;
            }
            if(usuario.Senha == senha){
                return true;
            }
            else{
                return false;
            }
        }

    }
}
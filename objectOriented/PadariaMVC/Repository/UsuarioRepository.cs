using System;
using System.Collections.Generic;
using PadariaMVC.ViewModel;

namespace PadariaMVC.Repository {
    public class UsuarioRepository {
        static List<UsuarioViewModel> listaDeUsuarios = new List<UsuarioViewModel> ();
        ///<summary>Método de inserção do usuário na lista do repositório</summary>
        ///<param name="objetoUsuario">Objeto do tipo UsuarioViewModel</param>
        ///<returns>Retorna um objeto do tipo UsuarioViewModel.false Sugere-se que o método seja usado junto com um construtor.</returns>
        public UsuarioViewModel InserirUsuario (UsuarioViewModel objetoUsuario) {
            objetoUsuario.Id = listaDeUsuarios.Count + 1;
            objetoUsuario.DataCriacao = DateTime.Now;

            listaDeUsuarios.Add (objetoUsuario);

            return objetoUsuario;
        }
        ///<summary>Método de acesso à lista de usuários cadastrados.</summary>
        ///<returns>Retorna uma lista de usuários cadastrados previamente.</returns>
        public List<UsuarioViewModel> ListarUsuarios () {
            return listaDeUsuarios;
        }
        ///<summary>Compara as informações inseridas pelo usuário com todos os dados cadastrados previamente.</summary>
        ///<param name="email">Email do usuário</param>
        ///<param name="senha">Senha do usuário</param>
        ///<returns>Retorna um objeto do tipo UsuarioViewModel caso a comparação seja validade e nulo no caso contrário.</returns>
        public UsuarioViewModel BuscarUsuario (string email, string senha) {
            foreach (var usuario in listaDeUsuarios) {
                if (email.Equals (usuario.Email) && senha.Equals (usuario.Senha)) {
                    return usuario;
                } else {
                    continue;
                }
            }
            return null;
        }
    }

}
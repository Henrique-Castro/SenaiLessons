using System;
using System.Collections.Generic;
using PadariaMVC.ViewModel;

namespace PadariaMVC.Repository {
    public class UsuarioRepository : UsuarioViewModel {
        static List<UsuarioViewModel> listaDeUsuarios = new List<UsuarioViewModel> ();
        public UsuarioViewModel Inserir (UsuarioViewModel objetoUsuario) {
            objetoUsuario.Id = listaDeUsuarios.Count + 1;
            objetoUsuario.DataCriacao = DateTime.Now;

            listaDeUsuarios.Add (objetoUsuario);

            return objetoUsuario;
        }

        public List<UsuarioViewModel> Listar () {
            return listaDeUsuarios;
        }
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
using System;
using System.Collections.Generic;
using System.IO;
using PadariaMVC.ViewModel;

namespace PadariaMVC.Repository {
    public class UsuarioRepository {
        static List<UsuarioViewModel> listaDeUsuarios = new List<UsuarioViewModel> ();
        ///<summary>Método de inserção do usuário na lista do repositório</summary>
        ///<param name="objetoUsuario">Objeto do tipo UsuarioViewModel</param>
        ///<returns>Retorna um objeto do tipo UsuarioViewModel.false Sugere-se que o método seja usado junto com um construtor.</returns>
        public UsuarioViewModel InserirUsuario (UsuarioViewModel objetoUsuario) {
            List<UsuarioViewModel> listaDeUsuarios = Listar();
            if (listaDeUsuarios != null) {
                objetoUsuario.Id = listaDeUsuarios.Count + 1;
            }else{
            objetoUsuario.Id = 1;
            }
            objetoUsuario.DataCriacao = DateTime.Now;

            StreamWriter sw = new StreamWriter ("usuarios.csv", true);
            sw.WriteLine ($"{objetoUsuario.Id};{objetoUsuario.Nome};{objetoUsuario.Email};{objetoUsuario.Senha}; {objetoUsuario.DataCriacao}");
            sw.Close ();

            return objetoUsuario;
        }
        ///<summary>Método de acesso à lista de usuários cadastrados.</summary>
        ///<returns>Retorna uma lista de usuários cadastrados previamente.</returns>
        public List<UsuarioViewModel> Listar () {
            listaDeUsuarios = new List<UsuarioViewModel>();
            UsuarioViewModel usuario;
            if(!File.Exists("usuarios.csv")){
                return null;
            }
            string[] arquivoUsuarios = File.ReadAllLines("usuarios.csv");
            
            foreach (var item in arquivoUsuarios)
            {
                string[] dadosDoUsuario = item.Split(';');
                usuario = new UsuarioViewModel();
                usuario.Id = int.Parse(dadosDoUsuario[0]);
                usuario.Nome = dadosDoUsuario[1];
                usuario.Email = dadosDoUsuario[2];
                usuario.Senha = dadosDoUsuario[3];
                usuario.DataCriacao = DateTime.Parse(dadosDoUsuario[4]);

                listaDeUsuarios.Add(usuario);
            }
            return listaDeUsuarios;
        }
        ///<summary>Compara as informações inseridas pelo usuário com todos os dados cadastrados previamente.</summary>
        ///<param name="email">Email do usuário</param>
        ///<param name="senha">Senha do usuário</param>
        ///<returns>Retorna um objeto do tipo UsuarioViewModel caso a comparação seja validade e nulo no caso contrário.</returns>
        public UsuarioViewModel BuscarUsuario (string email, string senha) {
            List<UsuarioViewModel> listaDeUsuarios = Listar ();
            foreach (var usuario in listaDeUsuarios) {
                if (usuario != null) {

                    if (email.Equals (usuario.Email) && senha.Equals (usuario.Senha)) {
                        return usuario;
                    } else {
                        continue;
                    }
                }
            }
            return null;
        }
    }

}
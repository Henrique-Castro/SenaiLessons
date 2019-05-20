using System;
using System.Collections.Generic;
using System.IO;
using ToDoList.ModelView;

namespace ToDoList.Repository {
    public class UsuarioRepository {
        private static List<UsuarioModelView> listaDeUsuarios = new List<UsuarioModelView> ();

        ///<summary>Insere o usuário cadastrado na plataforma de armazenamento escolhida e também define seu ID com base na quantidade de usuários já existentes.</summary>
        ///<param name="usuarioModelView">Objeto usuário</param>
        ///<returns>Retorna um objeto do tipo UsuarioModelView.</returns>
        public UsuarioModelView InserirUsuario (UsuarioModelView u) {

            //Gera um arquivo CSV   
            StreamWriter sw = new StreamWriter ("usuarios.csv", true);

            sw.WriteLine ($"{u.Id};{u.Nome};{u.Email};{u.Senha};{u.Senha};{u.DataCriacao}");
            sw.Close ();

            return u;
        }

        public static UsuarioModelView BuscarUsuarioPorNome (string nome) {

            foreach (UsuarioModelView usuario in listaDeUsuarios) {
                if (usuario.Nome.Equals (nome)) {
                    return usuario;
                }
            }
            return null;
        }
        public static UsuarioModelView BuscarUsuarioPorEmail (string email) {

            foreach (UsuarioModelView usuario in listaDeUsuarios) {
                if (usuario.Email.Equals (email)) {
                    return usuario;
                }
            }
            return null;
        }
        public static UsuarioModelView BuscarUsuarioPorId (int id) {

            foreach (UsuarioModelView usuario in listaDeUsuarios) {
                if (usuario.Id == id) {
                    return usuario;
                }
            }
            return null;
        }
        public List<UsuarioModelView> Listar () {
            StreamReader sr = new StreamReader ("usuarios.csv", true);
            UsuarioModelView usuario;
            if (File.Exists ("usuarios.csv")) {
                return null;
            }
            string[] listaDeUsuario = File.ReadAllLines ("usuarios.csv");
            foreach (var item in listaDeUsuario) {
                if (item != null) {
                    string[] dadosDeCadaUsuario = item.Split(";");
                    usuario = new UsuarioModelView ();
                    usuario.Id = int.Parse (dadosDeCadaUsuario[0]);
                    usuario.Nome = dadosDeCadaUsuario[1];
                    usuario.Email = dadosDeCadaUsuario[2];
                    usuario.Senha = dadosDeCadaUsuario[3];
                    usuario.DataCriacao = DateTime.Parse (dadosDeCadaUsuario[4]);

                    listaDeUsuarios.Add (usuario);
                }

            }
            return listaDeUsuarios;
        }
    }
}
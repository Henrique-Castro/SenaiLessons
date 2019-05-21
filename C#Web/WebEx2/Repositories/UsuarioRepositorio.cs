using System;
using System.Collections.Generic;
using System.IO;
using WebEx2.Models;

namespace WebEx2.Repositories {
    public class UsuarioRepositorio {
        public static List<UsuarioModel> UserList = new List<UsuarioModel> ();
        public UsuarioModel Cadastrar (UsuarioModel usuario) {
            StreamWriter sw = new StreamWriter ("usuarios.csv", true);
            if (File.Exists ("usuarios.csv") && Listar () != null) {
                usuario.Id = Listar ().Count + 1;
            }
            sw.WriteLine ($"{usuario.Id};{usuario.Name};{usuario.Email};{usuario.Password};{usuario.BirthDate}");
            sw.Close ();
            return usuario;
        }
        ///<returns>If the csv file "usuarios.csv" exists, returns the list of type UsuarioModel as requested else, returns null.</returns>
        public List<UsuarioModel> Listar () {
            UserList.Clear ();
            if (File.Exists ("usuarios.csv")) {
                var listaNaoTratada = File.ReadAllLines ("usuarios.csv");

                foreach (var usuario in listaNaoTratada) {
                    if (usuario != null) {
                        var dados = usuario.Split (";");
                        var usuarioRecuperado = new UsuarioModel (
                            id: int.Parse (dados[0]),
                            name: dados[1],
                            email: dados[2],
                            password: dados[3],
                            birthDate: DateTime.Parse (dados[4])
                        );
                        UserList.Add (usuarioRecuperado);
                    }
                }
                return UserList;
            }
            return null;
        }
    }
}
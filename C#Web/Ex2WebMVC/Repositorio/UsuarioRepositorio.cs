using System;
using System.Collections.Generic;
using System.IO;
using Ex2WebMVC.Models;

namespace Ex2WebMVC.Repositorio {
    public class UsuarioRepositorio {
        List<UsuarioModel> ListaDeUsuarios = new List<UsuarioModel> ();
        public UsuarioModel CadastrarUsuario (UsuarioModel usuario) {
            if (File.Exists ("usuarios.csv")) {
                usuario.Id = File.ReadAllLines ("usuarios.csv").Length + 1;
            } else {
                usuario.Id = 1;
            }

            StreamWriter sw = new StreamWriter ("usuarios.csv", true);
            sw.WriteLine ($"{usuario.Id};{usuario.Nome};{usuario.Email};{usuario.Senha};{usuario.DataNascimento}");
            sw.Close ();

            return usuario;
        }

        public List<UsuarioModel> Listar () {
            ListaDeUsuarios.Clear ();
            string[] dadoss = File.ReadAllLines ("usuarios.csv");
            UsuarioModel usuario;

            foreach (var item in dadoss) {
                if (string.IsNullOrEmpty (item)) {
                    //sair do foreach
                    continue;
                }
                string[] dados = item.Split (";");

                usuario = new UsuarioModel (
                    id: int.Parse (dados[0]),
                    nome: dados[1],
                    email: dados[2],
                    senha: dados[3],
                    dataNascimento: DateTime.Parse (dados[4])
                );
                ListaDeUsuarios.Add (usuario);
            }
            return ListaDeUsuarios;
        }
        public UsuarioModel BuscarPorId (int id) {
            ListaDeUsuarios = Listar ();
            foreach (var item in ListaDeUsuarios) {
                if (item.Id == id) {
                    return item;
                }
            }
            return null;
        }

        public UsuarioModel EditarUsuario (UsuarioModel usuarioNovo) {
            string[] linhas = File.ReadAllLines ("usuarios.csv");

            for (int i = 0; i < linhas.Length; i++) {
                if (string.IsNullOrEmpty (linhas[i])) {
                    continue;
                }
                string[] dadosDoUsuario = linhas[i].Split (";");
                if (int.Parse (dadosDoUsuario[0]) == usuarioNovo.Id) {
                    linhas[i] = $"{usuarioNovo.Id};{usuarioNovo.Nome};{usuarioNovo.Email};{usuarioNovo.Senha};{usuarioNovo.DataNascimento}";
                }
            }//for ending
            File.WriteAllLines ("usuarios.csv", linhas);
            return usuarioNovo;
        }
    }
}
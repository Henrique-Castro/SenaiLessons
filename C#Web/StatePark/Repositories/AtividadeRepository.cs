using System.Collections.Generic;
using System.IO;
using StatePark.Controllers;
using StatePark.Models;
using StatePark.ViewModels;

namespace StatePark.Repositories {
    public class AtividadeRepository {
        const string Atividades_Path = "Database/Atividades.csv";
        const string Marcas_Path = "Database/Marcas.csv";
        const string Modelos_Path = "Database/Modelos.csv";
        static List<AtividadeModel> ListaDeAtividades = new List<AtividadeModel> ();
        public static void InserirAtividade (AtividadeModel atividade) {

            ListaDeAtividades = ListarAtividades ();
            if (ListaDeAtividades == null) {
                atividade.Id = 1;
            } else {
                atividade.Id = ListaDeAtividades.Count + 1;
            }
            File.AppendAllText (Atividades_Path, $"{atividade.Id};{atividade.Condutor.NomeCondutor};{atividade.Carro.Marca};{atividade.Carro.Modelo};{atividade.Carro.Placa}\n");
        }
        public static List<AtividadeModel> ListarAtividades () {
            ListaDeAtividades.Clear();
            var listaDeAtividades = File.ReadAllLines (Atividades_Path);
            foreach (var item in listaDeAtividades) {
                var dados = item.Split (";");
                var carroModel = new CarroModel (
                    marca: dados[2],
                    modelo: dados[3],
                    placa: dados[4]
                );
                var condutorModel = new CondutorModel (
                    nomeCondutor: dados[1],
                    carro: carroModel
                );
                var atividadeModel = new AtividadeModel (
                    id: int.Parse (dados[0]),
                    condutor: condutorModel,
                    carro: carroModel
                );
                ListaDeAtividades.Add (atividadeModel);
            }
            return ListaDeAtividades;
        }
        public static List<string> ListarMarcas () {
            var arrayDeMarcas = File.ReadAllLines (Marcas_Path);
            List<string> listaDeMarcas = new List<string> ();
            foreach (var item in arrayDeMarcas) {
                if (item != null) {
                    listaDeMarcas.Add (item);
                } else {
                    break;
                }
            }
            return listaDeMarcas;
        }
        public static List<string> ListarModelos () {
            var arrayDeModelos = File.ReadAllLines (Modelos_Path);
            List<string> listaDeModelos = new List<string> ();
            foreach (var item in arrayDeModelos) {
                if (item == null) {
                    break;
                } else {
                    var modelos = item.Split (";");
                    for (int i = 1; i < modelos.Length; i++) {
                        listaDeModelos.Add (modelos[i]);
                    }
                }
            }
            return listaDeModelos;
        }
        public static List<string> ListarModelosPorMarca (string marca) {
            var arrayDeModelos = File.ReadAllLines (Modelos_Path);
            List<string> listaDeModelos = new List<string> ();
            foreach (var linha in arrayDeModelos) {
                var modelos = linha.Split (";");
                if (modelos[0].Equals (marca)) {
                    for (int i = 1; i < modelos.Length; i++) {
                        listaDeModelos.Add (modelos[i]);
                    }
                }
            }

            return listaDeModelos;
        }

    }
}
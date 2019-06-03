using System.Collections.Generic;
using StatePark.Models;

namespace StatePark.ViewModels {
    public class AtividadeViewModel {
        public List<string> ListaDeMarcas { get; set; }
        public List<string> ListaDeModelos { get; set; }
        public List<AtividadeModel> ListaDeAtividades{get;set;}

        public AtividadeViewModel (List<string> listaDeMarcas, List<string> listaDeModelos, List<AtividadeModel> listaDeAtividades) {
            ListaDeMarcas = listaDeMarcas;
            ListaDeModelos = listaDeModelos;
            ListaDeAtividades = listaDeAtividades;
        }
    }
}
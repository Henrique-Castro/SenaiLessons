using System.Collections.Generic;

namespace StatePark.Models {
    public class AtividadeModel {
        
        public int Id { get; set; }
        public CarroModel Carro { get; set; }
        public CondutorModel Condutor { get; set; }
        public List<string> ListaDeMarcas { get; set; }
        public List<string> ListaDeModelos { get; set; }
        public AtividadeModel (CondutorModel condutor, CarroModel carro) {
            Carro = carro;
            Condutor = condutor;
        }
        public AtividadeModel (int id, CondutorModel condutor, CarroModel carro) {
            Id = id;
            Carro = carro;
            Condutor = condutor;
        }
        public AtividadeModel (List<string> listaDeMarcas, List<string> listaDeModelos) {
            ListaDeMarcas = listaDeMarcas;
            ListaDeModelos = listaDeModelos;
        }
    }
}
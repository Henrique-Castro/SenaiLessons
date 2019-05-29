namespace StatePark.Models
{
    public class CondutorModel
    {
        public string NomeCondutor{get;set;}
        public CarroModel Carro{get;set;}
        public CondutorModel(){
            
        }
        public CondutorModel(string nomeCondutor, CarroModel carro){
            NomeCondutor = nomeCondutor;
            Carro = carro;
        }
    }
}
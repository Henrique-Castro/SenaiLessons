namespace StatePark.Models
{
    public class CarroModel
    {
        public string Placa{get;set;}
        public string Marca{get;set;}
        public string Modelo{get;set;}
        public CarroModel(){

        }
        public CarroModel(string placa, string marca, string modelo){
            Placa = placa;
            Marca = marca;
            Modelo = modelo;
        }
    }
}
namespace StatePark.Models
{
    public class AtividadeModel
    {
        public int Id { get; set; }
        public CarroModel Carro { get; set; }
        public CondutorModel Condutor { get; set; }

        public AtividadeModel (CondutorModel condutor, CarroModel carro) {
            Carro = carro;
            Condutor = condutor;
        }
        public AtividadeModel (int id, CondutorModel condutor, CarroModel carro) {
            Id = id;
            Carro = carro;
            Condutor = condutor;
        }
    }
}
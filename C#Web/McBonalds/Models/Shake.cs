namespace McBonalds.Models
{
    public class Shake : Produto
    {
        public Shake(string nome){
            Nome = nome;
        }
        public Shake(ulong id, string nome, double preco){
            Id = id;
            Nome = nome;
            Preco = preco;
        }
    }
}
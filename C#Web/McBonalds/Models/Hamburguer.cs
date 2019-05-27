namespace McBonalds.Models
{
    public class Hamburguer : Produto
    {
        public Hamburguer(string nome){
            Nome = nome;
        }
        public Hamburguer(ulong id, string nome, float preco){
            Id = id;
            Nome = nome;
            Preco = preco;
        }
    }
}
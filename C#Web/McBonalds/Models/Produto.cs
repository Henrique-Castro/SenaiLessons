namespace McBonalds.Models
{
    public class Produto
    {
        public ulong Id{get;set;}
        public string Nome{get;set;}
        public double Preco{get;set;}
    }
    //Virtual define um padrão que pode ser sobrescrito ou não
    //Abstract define algo que foi feito para ser herdado, os métodos abstrados DEVEM SER SOBRESCRITOS
}
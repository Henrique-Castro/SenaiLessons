
namespace PadariaMVC.ViewModel {
    public class ProdutoViewModel : BaseViewModel
    {
        public string Categoria { get; set; }
        public float Preco { get; set; }
        public string Descricao { get; set; }
        public int IdResponsavel;
        public ProdutoViewModel(){
            
        }
        public ProdutoViewModel(int idResponsavel,string nome, string categoria,  string descricao, float preco){
            Nome = nome;
            Categoria = categoria;
            Descricao = descricao;
            Preco = preco;
            Id = Id++;
            IdResponsavel = idResponsavel;
        }
    }
}
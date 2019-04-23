using System;
using System.Runtime.CompilerServices;
namespace desafioPizzaria {
    public class Produto {
        public static int contador = 0;
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public float Preco { get; set; }
        public string Categoria { get; set; }
        public DateTime DataCriacao { get; set; }

        static Produto[] arrayProdutos = new Produto[100];

        public Produto (string nome, string descricao, string categoria, float preco) {
            this.Id = contador + 1;
            this.Nome = nome;
            this.Categoria = categoria;
            this.Descricao = descricao;
            this.Preco = preco;
            this.DataCriacao = DateTime.Now;
        }
        public static void CadastrarProduto () {
            string nome, descricao, categoria;
            float preco;
            System.Console.WriteLine ($"Este é o produto número: {contador+1}");
            System.Console.Write ("Nome do produto: ");
            nome = Console.ReadLine ();
            System.Console.Write ("Descrição: ");
            descricao = Console.ReadLine ();
            System.Console.Write ("Preço (00,00): ");
            preco = float.Parse (Console.ReadLine ());
            categoria:
                System.Console.WriteLine ("Categoria (Pizza/Bebida): ");
            categoria = Console.ReadLine ();
            if (!categoria.Equals ("Pizza", StringComparison.CurrentCultureIgnoreCase) && !categoria.Equals ("Bebida", StringComparison.CurrentCultureIgnoreCase)) {
                Console.ForegroundColor = ConsoleColor.Red;
                System.Console.WriteLine ("Existem apenas duas categorias de produtos: Pizza e bebida. Cadastre a categoria novamente.");
                Console.ResetColor ();
                goto categoria;
            }
            Produto produto = new Produto (nome, descricao, categoria, preco);
            arrayProdutos[contador] = produto;
            contador++;
        }

        public static string BuscarPorId () {
            System.Console.Write ("Digite o ID do produto desejado: ");
            foreach (var produto in arrayProdutos) {
                if (produto == null) {
                    return "Não há nenhum produto cadastrado.";
                }
                if (int.Parse (Console.ReadLine ()) == produto.Id) {
                    return $"ID: {produto.Id}\nNome: {produto.Nome}\nCategoria: {produto.Categoria}\nDescrição: {produto.Descricao}\nPreço: R${produto.Preco}\nData de criação: {produto.DataCriacao}";
                } else {
                    return "Não há produto cadastrado com esse ID.";
                }
            }
            return "Ocorreu um erro desconhecido.";
        }

        public static void ListarProdutos () {
            foreach (var produto in arrayProdutos) {
                if(produto == null){
                    break;
                }
                System.Console.WriteLine ("----------------------");
                System.Console.WriteLine ($"ID: {produto.Id}");
                System.Console.WriteLine ($"Nome: {produto.Nome}");
                System.Console.WriteLine ($"Preço: {produto.Preco}");
                System.Console.WriteLine ("----------------------");
            }
            System.Console.WriteLine("\nAperte ENTER para voltar ao menu");
            Console.ReadLine();
        }
    }
}
using System.IO;
using System;
using System.Collections.Generic;
using PadariaMVC.Utils;
using PadariaMVC.Utils.Enums;
using PadariaMVC.ViewModel;

namespace PadariaMVC.Repository {
    public class ProdutoRepository {
        static List<ProdutoViewModel> listaDeProdutos = new List<ProdutoViewModel> ();
        ///<summary>Método de inserção do produto na lista do repositório</summary>
        ///<param name="objetoProduto">Objeto do tipo ProdutoViewModel</param>
        ///<returns>Retorna um objeto do tipo ProdutoViewModel.false Sugere-se que o método seja usado junto com um construtor.</returns>
        public ProdutoViewModel InserirProduto (int IdResponsavel,ProdutoViewModel objetoProduto) {
            // Console.Write (BuscarProdutoPorNome (null).Id);
            foreach (var item in listaDeProdutos) {
                if (item.Nome == null) {
                    objetoProduto.Id = item.Id;
                } else {
                    objetoProduto.Id = listaDeProdutos.Count + 1;
                }
            }
            objetoProduto.DataCriacao = DateTime.Now;

            listaDeProdutos.Add (objetoProduto);
            StreamWriter sw = new StreamWriter("produtos.csv", true);
            sw.WriteLine($"{objetoProduto.IdResponsavel};{objetoProduto.Id};{objetoProduto.Nome};{objetoProduto.Descricao};{objetoProduto.Categoria};{objetoProduto.Preco};{objetoProduto.DataCriacao}");
            sw.Close();
            return objetoProduto;
        }
        ///<summary>Método de acesso à lista de produtos cadastrados.</summary>
        ///<returns>Retorna uma lista de produtos cadastrados previamente.</returns>
        public List<ProdutoViewModel> ListarProdutos () {
            listaDeProdutos = new List<ProdutoViewModel>();
            int contador = 0;
            ProdutoViewModel produto;
            if(!File.Exists("produtos.csv")){
                return null;
            }
            string[] arquivoUsuarios = File.ReadAllLines("produtos.csv");
            
            foreach (var item in arquivoUsuarios)
            {
                string[] dadosDoProduto = item.Split(';');
                produto = new ProdutoViewModel();
                produto.IdResponsavel = int.Parse(dadosDoProduto[0]);
                produto.Id = int.Parse(dadosDoProduto[1]);
                produto.Nome = dadosDoProduto[2];
                produto.Descricao = dadosDoProduto[3];
                produto.Categoria = dadosDoProduto[4];
                produto.Preco = float.Parse(dadosDoProduto[5]);
                produto.DataCriacao = DateTime.Parse(dadosDoProduto[6]);

                listaDeProdutos.Add(produto);
            }
            return listaDeProdutos;
        }
        ///<summary>Compara a informação inserida pelo usuário com todos os dados cadastrados previamente.</summary>
        ///<param name="nome">Nome do produto</param>
        ///<returns>Retorna um objeto do tipo ProdutoViewModel caso o produto seja encontrado e nulo no caso contrário.</returns>
        public static ProdutoViewModel BuscarProdutoPorNome (string nome) {
            foreach (var produto in listaDeProdutos) {
                if (nome.Equals (produto.Nome)) {
                    return produto;
                } else {
                    continue;
                }
            }
            return null;
        }
        ///<summary>Caso o nome inserido seja válido, remove o produto.</summary>
        ///<param name="produtoRecebido">Objeto do tipo ProdutoViewModel</param>
        public static void Remover (ProdutoViewModel produtoRecebido) {
            listaDeProdutos.Remove (BuscarProdutoPorNome (produtoRecebido.Nome));
            Mensagem.MostrarMensagem ("Produto removido com sucesso!", TipoMensagemEnum.SUCESSO);
        }
        public static void Alterar(ProdutoViewModel produtoASerAlterado, ProdutoViewModel produtoJaAlterado){
            //Arranja um jeito de passar os valores recebidos para o produto que já existe (Será que dá pra usar um construtor??)
            foreach (var item in listaDeProdutos){
                if(item.Nome == produtoASerAlterado.Nome){
                    item.Nome = produtoJaAlterado.Nome;
                    item.Preco = produtoJaAlterado.Preco;
                    item.Categoria = produtoJaAlterado.Categoria;
                    item.Descricao = produtoJaAlterado.Descricao;

                }
            }
        }
    }
}
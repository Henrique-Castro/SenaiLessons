using System.Security.Cryptography;
using System;
using System.Collections.Generic;
using PadariaMVC.Repository;
using PadariaMVC.Utils;
using PadariaMVC.Utils.Enums;
using PadariaMVC.ViewModel;
namespace PadariaMVC.ViewController {
    public class ProdutoViewController {
        //Instanciar o objeto
        static ProdutoViewModel produtoViewModel;
        //Instanciar o repositório
        static ProdutoRepository produtoRepository = new ProdutoRepository();
        static public void CadastrarProduto(){
            string nome, categoria, descricao;
            float preco = 0;
            //Nome do produto
            do{
            System.Console.Write("Nome do produto: ");
            nome = Console.ReadLine();
            if(!ValidacaoUtil.ValidarNome(nome)){
                Mensagem.MostrarMensagem("Nome inválido.", TipoMensagemEnum.ERRO);
            }
            //Categoria
            }while(!ValidacaoUtil.ValidarNome(nome));
            do{
                System.Console.Write("Categoria: ");
                categoria = Console.ReadLine();
                if(!ValidacaoUtil.ValidarNome(categoria)){
                    Mensagem.MostrarMensagem("Categoria inválida.", TipoMensagemEnum.ERRO);
                }
            }while(!ValidacaoUtil.ValidarNome(categoria));
            //Descrição
            do{
                System.Console.WriteLine("Descrição: ");
                descricao = Console.ReadLine();
                if(!ValidacaoUtil.ValidarNome(descricao)){
                    Mensagem.MostrarMensagem("Descrição inválida.", TipoMensagemEnum.ERRO);
                }
            }while(!ValidacaoUtil.ValidarNome(descricao));
            //PREÇO
            do{
                System.Console.WriteLine("Preço (digite apenas números): ");
                string precoCapturado = Console.ReadLine();
                
                if(!ValidacaoUtil.ValidarPreco(precoCapturado, preco)){
                    Mensagem.MostrarMensagem("Preço inválido", TipoMensagemEnum.ERRO);
                }
                preco = float.Parse(precoCapturado);
                
            }while(!ValidacaoUtil.ValidarPreco(preco));
            produtoViewModel = new ProdutoViewModel(nome, categoria, descricao, preco);

            produtoRepository.InserirProduto(produtoViewModel);
            

        }
        ///<summary>Lista todos os produtos previamente cadastrados, exibindo seus atributos: Id, Nome, Categoria, Descrição e Data de Criação</summary>
        public static void ListarProdutos () {
            List<ProdutoViewModel> listaDeProdutos = produtoRepository.ListarProdutos ();
            if(listaDeProdutos == null){
                Mensagem.MostrarMensagem("Não há nenhum produto armazenado.", TipoMensagemEnum.ALERTA);
            }else{
            foreach (var item in listaDeProdutos) {
                System.Console.WriteLine ($"______________________________\nId: {item.Id}\nNome: {item.Nome}\nCategoria: {item.Categoria} \nDescrição: {item.Descricao}\nPreço: {item.Preco}\nData de criação: {item.DataCriacao}\n______________________________");
            }
            Mensagem.MostrarMensagem("Produtos listados.", TipoMensagemEnum.SUCESSO);
            }
        }
        ///<summary>Recebe o nome do produto a ser removido, faz a busca dele na lista de produtos cadastrados e realiza a exclusão com todas as validações necessárias.</summary>
        public static void RemoverProduto(){
            string nome;
            ProdutoViewModel produto = new ProdutoViewModel();
            do{
            System.Console.Write("Nome do produto a ser removido: ");
            nome = Console.ReadLine();
            if(!ValidacaoUtil.ValidarNome(nome)){
                Mensagem.MostrarMensagem("Digite um nome.", TipoMensagemEnum.ALERTA);
            }
            }while(!ValidacaoUtil.ValidarNome(nome));
            produto = ProdutoRepository.BuscarProdutoPorNome(nome);
            do{
            if(produto == null){
                Mensagem.MostrarMensagem("Este produto não existe.", TipoMensagemEnum.ALERTA);
            }
            ProdutoRepository.Remover(produto);
            }while(produto == null);
        }
        ///<summary></summary>
        public static void AlterarProduto(){
            string nome;
            ProdutoViewModel produtoASerAlterado = new ProdutoViewModel();
            do{
                System.Console.Write("Nome do produto a ser alterado: ");
                nome = Console.ReadLine();
                if(!ValidacaoUtil.ValidarNome(nome)){
                    Mensagem.MostrarMensagem("Digite um nome de produto válido", TipoMensagemEnum.ALERTA);
                }
            }while(!ValidacaoUtil.ValidarNome(nome));
            
            produtoASerAlterado = ProdutoRepository.BuscarProdutoPorNome(nome);
            if(produtoASerAlterado == null){
                Mensagem.MostrarMensagem("O produto desejado não existe.", TipoMensagemEnum.ERRO);
            }

        }
    }
}
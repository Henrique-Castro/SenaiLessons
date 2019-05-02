using System;
using PadariaMVC.ViewModel;

namespace PadariaMVC.Utils {
    public class MenuUtils {
        public static void MostrarMenuDeslogado () {
            string[] menu = {
                "____________Padaria____________",
                "||_________PADACASTRO________||",
                "||     (1) Cadastrar Usuário ||",
                "||     (2) Efetuar Login     ||",
                "||     (3) Listar            ||",
                "||___________________________||",
                "||     (0) Sair              ||",
                "_______________________________"
            };
            Console.Clear();
            foreach (string linha in menu) {
                System.Console.WriteLine (linha);
            }
            System.Console.Write ("Escolha uma opção:");
        }
        ///<summary>Exibe o menu acessível apenas para usuários que tenham passado pela validação do login.</summary>
        ///<param name="usuario">Objeto contento o usuário que passou pela validação do login.</param>
        public static void MostrarMenuLogado (UsuarioViewModel usuarioLogado) {
            string[] menu = {
                $"          Bem vindo, {usuarioLogado.Nome}! ",
                "____________________________________________",
                "           (1) Cadastrar Produto            ",
                "           (2) Listar                       ",
                "           (3) Buscar Produto por Nome      ",
                "           (4) Valor Total                  ",
                "           (5) Alterar                      ",
                "           (6) Remover                      ",
                "____________________________________________",
                "           (0) Deslogar                     ",
            };
            // Console.Clear();
            
            foreach (string linha in menu) {
                System.Console.WriteLine (linha);
            }
            System.Console.Write ("Escolha uma opção:");
        }
        public static void MostrarMenuAlterarProduto(){
            string[] menu = {
                "                                         ",
                "               1- Nome                   ",
                "               2- Categoria              ",
                "               3- Descrição              ",
                "               4- Preço                  ",
                "               0- Voltar                 ",
                "_________________________________________",
                "Qual informação você deseja alterar?"
            };
            foreach (string linha in menu)
            { 
              System.Console.WriteLine(linha);  
            }
        }
    }
}
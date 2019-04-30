using PadariaMVC.ViewModel;

namespace PadariaMVC.Utils
{
    public class MenuUtils {
        public static void MostrarMenuDeslogado () {
            string[] menu = {
                "============Padaria============",
                "||                           ||",
                "||---------PadaCastro--------||",
                "||     (1) Cadastrar Usuário ||",
                "||     (2) Efetuar Login     ||",
                "||     (3) Listar            ||",
                "||---------------------------||",
                "||     (0) Sair              ||",
                "==============================="
            };
            foreach (string linha in menu) {
                System.Console.WriteLine (linha);
            }
        }
        public static void MostrarMenuLogado (UsuarioViewModel usuarioLogado) {
            string[] menu = {
                $"          Bem vindo, {usuarioLogado.Nome}! ",
                "____________________________________________",
                "           (1) Cadastrar Produto            ",
                "           (2) Listar                       ",
                "           (3) Valor Total                  ",
                "           (4) Alterar                      ",
                "           (4) Remover                      ",
                "--------------------------------------------",
                "           (0) Sair                         "
            };
            foreach (string linha in menu){
                System.Console.WriteLine(linha);
            }
        }
    }
}
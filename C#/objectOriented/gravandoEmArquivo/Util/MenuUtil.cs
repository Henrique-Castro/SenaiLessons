using System;
namespace gravandoEmArquivo.Util {
    public class MenuUtil {
        static string[] menuDeslogado = {
            "___________________________",
            "|    Cadastrar Usuário    |",
            "|    Listar               |",
            "|    Efetuar Login        |",
            "|    Sair                 |",
            "|_________________________|"
        };
        static int selectedItem;
        public static void Navigation () {
            ConsoleKeyInfo key;
            key = Console.ReadKey(true);
            
            do {
                for (int i = 1; i < menuDeslogado.Length - 1; i++) {

                    foreach (string linha in menuDeslogado) {
                    if(selectedItem = inde linha)
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                        System.Console.WriteLine (linha);

                    }

                }

            } while (selectedItem < 5 && selectedItem > 0);
        }
        public static void MenuDeslogado () {

            foreach (string linha in menuDeslogado) {
                System.Console.WriteLine (linha);
            }
        }
    }
}
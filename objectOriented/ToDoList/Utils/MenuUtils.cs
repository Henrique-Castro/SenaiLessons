using System;

namespace ToDoList.Utils {
    public class MenuUtil {
        public static void MostrarMenuInicial () {
            int item = 1;
            string[] menu = {
                "_________________________",
                "|       ToDo List        |",
                "|                        |",
                $"|    {item}- Criar conta      |",
                $"|    {++item}- Efetuar login    |",
                "|________________________|",
                "|    0- Encerrar sessão  |",
                "|________________________|"
            };
            foreach (string linha in menu) {
                System.Console.WriteLine (linha);
                item++;

            }
        }
        public static void MostrarMenuTipoUsuario () {
            int item = 1;
            string[] menu = {
                "_________________________",
                "|   Tipo de usuário:     |",
                $"|    {item}- Usuário          |",
                $"|    {++item}- Administrador    |",
                "|________________________|",
                "|    0- Voltar           |",
                "|________________________|"
            };
            Console.Clear();
            foreach (string linha in menu)
            {
                System.Console.WriteLine(linha);
            }
        }
    }
}
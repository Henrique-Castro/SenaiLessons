using System;

namespace PadariaMVC.Utils
{
    public class MenuUtils
    {
        public static void MostrarMenuDeslogado(){
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
                foreach(string linha in menu)
                {
                    System.Console.WriteLine(linha);
                } 
        }
        // public static void MostrarMenuLogado(){
        //     string[] menu = {"           (1) Cadastrar Produto            ";
        //    Console.WriteLine("           (2) Listar                       ";
        //    Console.WriteLine("           (3) Valor Total                  ";
        //    Console.WriteLine("           (4) Alterar                      ";
        //    Console.WriteLine("           (4) Remover                      ";
        //    Console.WriteLine("--------------------------------------------",

        //    Console.WriteLine("           (0) Sair                         "
        //     };
        // }
    }
}
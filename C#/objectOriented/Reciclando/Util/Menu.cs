using System;
using System.Collections.Generic;
using Reciclando.Controller;
using Reciclando.Model;
using Reciclando.Repository;
using Reciclando.Util.Enums;

namespace Reciclando.Util {
    public class Menu {
        public static void MostrarMenuLixos () {
            var listaDeLixos = Enum.GetNames (typeof (LixosEnum));
            string linha = "_________________________________________";
            bool querSair = false;
            bool lixoEscolhido = false;
            int lixoDestacado = 0;
            do {
                LixosEnum opcaoLixoSelecionado = new LixosEnum ();
                Console.Clear ();
                System.Console.WriteLine (linha);
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.White;
                System.Console.WriteLine ("              RECICLANDO!                ");
                Console.ResetColor ();
                for (int i = 0; i < listaDeLixos.Length; i++) {
                    string titulo = TratarTituloMenu (listaDeLixos[i]);

                    if (lixoDestacado == i) {
                        DestacarOpcao (listaDeLixos[i].Replace (i.ToString (), titulo).Replace ("_", " "));
                    } else {
                        System.Console.WriteLine (listaDeLixos[i].Replace (i.ToString (), titulo).Replace ("_", " "));
                    }
                }

                var tecla = Console.ReadKey (true).Key;

                switch (tecla) {
                    case ConsoleKey.UpArrow:
                        lixoDestacado = lixoDestacado == 0 ? lixoDestacado : --lixoDestacado;
                        break;
                    case ConsoleKey.DownArrow:
                        lixoDestacado = lixoDestacado == listaDeLixos.Length - 1 ? lixoDestacado : ++lixoDestacado;
                        break;
                    case ConsoleKey.Enter:
                        opcaoLixoSelecionado = (LixosEnum) Enum.Parse (typeof (LixosEnum), lixoDestacado.ToString ());
                        int codigo = lixoDestacado;
                        break;
                }

                switch (opcaoLixoSelecionado) {
                    case LixosEnum.FRUTA:
                                    
                        break;
                    case LixosEnum.GARRAFA_DE_PLASTICO:

                        break;
                    case LixosEnum.GARRAFA_DE_VIDRO:
                        break;
                    case LixosEnum.ISOPOR:
                        break;
                    case LixosEnum.PAPELAO:
                        break;
                    case LixosEnum.PAPEL:
                        break;
                    case LixosEnum.PILHA_ELETRICA:
                        break;
                    case LixosEnum.SAIR:
                        querSair = true;
                        break;
                }
            } while (!querSair);

        }
        public static void DestacarOpcao (string opcao) {

            Console.BackgroundColor = ConsoleColor.DarkRed;

            System.Console.WriteLine (opcao);

            Console.ResetColor ();

        }
        public static string TratarTituloMenu (string titulo) {

            return System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase (titulo.Replace ("_", " ").ToLower ());

        }
    }
}
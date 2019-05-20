using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using EscolaDeRock.Interfaces;
using EscolaDeRock.Models;

namespace EscolaDeRock {
    enum FormacaoEnum : uint {
        TRIO,
        QUARTETO
    }
    enum InstrumentosEnum : uint {
        BAIXO,
        BATERIA,
        CONTRABAIXO,
        GUITARRA,
        PIANO,
        TAMBORES,
        VIOLAO
    }
    class Program {

        static void Main (string[] args) {

            bool querSair = false;
            string barraMenu = "====================================";
            var menuFormacao = new List<string> () {
                "     - 0                        ", //32
                "     - 1                     " //29
            };

            var itensMenuFormacao = Enum.GetNames (typeof (FormacaoEnum));
            int opcaoFormacaoSelecionada = 0;
            do {
                bool formacaoEscolhida = false;
                do {
                    Console.Clear ();
                    System.Console.WriteLine (barraMenu);
                    System.Console.WriteLine ("            ESCOLA DE ROCK          ");
                    System.Console.WriteLine ("        Escolha uma formação:       ");
                    System.Console.WriteLine (barraMenu);
                    for (int i = 0; i < menuFormacao.Count; i++) {
                        string titulo = TratarTituloMenu (itensMenuFormacao[i]);

                        if (opcaoFormacaoSelecionada == i) {
                            DestacarOpcao (menuFormacao[i].Replace (i.ToString (), titulo).Replace ("-", ">"));
                        } else {
                            System.Console.WriteLine (menuFormacao[i].Replace (i.ToString (), titulo));
                        }
                    }

                    var tecla = Console.ReadKey (true).Key;

                    switch (tecla) {
                        case ConsoleKey.UpArrow:
                            opcaoFormacaoSelecionada = opcaoFormacaoSelecionada == 0 ? opcaoFormacaoSelecionada : --opcaoFormacaoSelecionada;
                            break;
                        case ConsoleKey.DownArrow:
                            opcaoFormacaoSelecionada = opcaoFormacaoSelecionada == menuFormacao.Count - 1 ? opcaoFormacaoSelecionada : ++opcaoFormacaoSelecionada;
                            break;
                        case ConsoleKey.Enter:
                            formacaoEscolhida = true;
                            break;

                    }
                } while (!formacaoEscolhida);

                bool bandaCompleta = false;
                int vagas = 0;

                switch (opcaoFormacaoSelecionada) {
                    case 0:
                        vagas = 2;
                        do {
                            ExibirMenuDeInstrumentos ();
                            System.Console.WriteLine ("Digite o código do instrumento para a categoria Harmonia");
                            int codigo = int.Parse (Console.ReadLine ());
                            var instrumento = Candidato.Instrumentos[codigo];
                            var interfaceEncontrada = instrumento.GetType ().GetInterface ("IHarmonia");
                            if (interfaceEncontrada != null) {
                                vagas--;
                                ColocarNaBanda ((IHarmonia) instrumento);
                            } else {
                                continue;
                            }
                            System.Console.WriteLine ("Digite o código do instrumento para a categoria Percussão");
                            codigo = int.Parse (Console.ReadLine ());
                            instrumento = Candidato.Instrumentos[codigo];
                            interfaceEncontrada = instrumento.GetType ().GetInterface ("IPercussao");
                            if (interfaceEncontrada != null) {
                                vagas--;
                                ColocarNaBanda ((IPercussao) instrumento);
                            } else {
                                continue;
                            }
                        } while (!bandaCompleta);
                        System.Console.WriteLine("Banda completa");
                        Console.ReadLine();
                        
                        break;
                    case 1:
                        vagas = 3;

                        break;
                }
            } while (!querSair);
        }
        public static string TratarTituloMenu (string titulo) {

            return System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase (titulo.Replace ("_", " ").ToLower ());

        }
        // public static void ExibirMenuDeCategorias () {

        //     var categorias = Enum.GetNames (typeof (CategoriaEnum));

        //     int codigo = 1;

        //     string menuInstrumentoBorda = "##############################";

        //     System.Console.WriteLine (menuInstrumentoBorda);

        //     System.Console.WriteLine ("#         Categorias        #");

        //     foreach (var categoria in categorias) {

        //         System.Console.WriteLine ($"  {codigo++}.{TratarTituloMenu(categoria)}");

        //     }

        //     System.Console.WriteLine (menuInstrumentoBorda);

        // }

        public static void ExibirMenuDeInstrumentos () {

            var instrumentos = Enum.GetNames (typeof (InstrumentosEnum));

            int codigo = 1;

            string menuInstrumentoBorda = "##############################";

            System.Console.WriteLine (menuInstrumentoBorda);

            System.Console.WriteLine ("#         Instrumentos        #");

            foreach (var instrumento in instrumentos)

            {

                System.Console.WriteLine ($"  {codigo++}.{TratarTituloMenu(instrumento)}");

            }

            System.Console.WriteLine (menuInstrumentoBorda);

        }
        public static void DestacarOpcao (string opcao) {

            Console.BackgroundColor = ConsoleColor.DarkRed;

            System.Console.WriteLine (opcao);

            Console.ResetColor ();

        }
        public static void ColocarNaBanda (IHarmonia instrumento) {
            instrumento.TocarAcordes ();
        }
        public static void ColocarNaBanda (IPercussao instrumento) {
            instrumento.ManterRitmo ();
        }
        public static void ColocarNaBanda (Interfaces.IMelodia instrumento) {
            instrumento.TocarSolo ();
        }
    }
}
using System;
namespace vrumAirLinesOO {
    class Program {

        static void Main (string[] args) {
            //     var vruum = new [] {
            //             @"  \----------------------------------\ ",
            //             @"  \                                  \        __",
            //             @"  \     BEM VINDO À                  \       | \ ",
            //             @"  >      VRUUM AIRLINES              >------|  \       ______",
            //             @"/                                  /       --- \_____/   _|_\____  | ",
            //             @"/                                  /          \_______ --------- __>-}",
            //             @"/----------------------------------/              /  \_____|_____/   | ",
            //             @"                                                  *         | ",
            //             @"                                                            O ",
            //             @"                                                                                ",
            //             @"    |*\       |*\       |*\       |*\       |*\       |*\       |*\",
            //             @" | * * * | | * * * | | * * * | | * * * | | * * * | | * * * | | * * * |",
            //             @"\ * / \ * / ____\ * / \ * / \ * / \ * / \ * / ",
            //             @" | | | | | | | | |",
            //             @" ^ ^ ^ ^ ^ ^ ^ ^ ^ ^ ^ ^ ^ ^ ^ ^ ^ ^ ^ ^ ^ ^ ^ ^ ^ ^ ^ ^ ^ ^ ^ ^ ^ ^ ^ ^ ^ ^ ^ ^ ^ ^ ^ ^ ^ ^ ^ ^ ^ ^ ^ ^ ^ ^ ^ ^ ^ ^ ^ ^ ^ ^ ^ ^ ^ ^ ^ ^ ^ ^ ^ ",
            //             @"
            //             ",
            //             @"-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --",
            // };
            // Console.WriteLine ("\n\n");
            // foreach (string line in vruum) {
            //     System.Console.WriteLine (line);
            // }
            Passageiro p = new Passageiro ();
            Passageiro[] arrayPassageiros = new Passageiro[5];

            int numPassageiros = 0;
            bool sair = false;

            while (!sair) {
                System.Console.WriteLine ("---------MENU---------");
                System.Console.WriteLine ("1 - Registrar passageiro\n2 - Exibir passageiros\n0 - Fechar");

                int codigo = int.Parse (Console.ReadLine ());

                switch (codigo) {
                    case 1:

                        System.Console.Write ("Digite o seu nome: ");
                        p.setNome (Console.ReadLine ());
                        System.Console.Write ("Número da passagem ");
                        p.setNumero (Console.ReadLine ());
                        System.Console.Write ("Data do vôo: ");
                        p.setData (DateTime.Parse (Console.ReadLine ()));
                        numPassageiros++;
                        arrayPassageiros[numPassageiros] = p;
                        break;

                    case 2:
                        foreach (var passageiro in arrayPassageiros) {
                            if (passageiro != null) {
                                System.Console.WriteLine ($"{passageiro.getNome()} \n Passagem número {passageiro.getNumero()}\n Data do vôo: {passageiro.getData()}");
                            }
                        }
                        break;
                    default:
                        System.Console.WriteLine ("A");
                        break;
                }
            }
        }
    }
}
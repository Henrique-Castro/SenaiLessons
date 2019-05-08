using System;

namespace dateTimeAviao {
    class Program {
        

        
        static void Main (string[] args) {
            var arr = new[]{
            @"  \----------------------------------\ ",
             @"  \                                  \        __",
              @"  \     BEM VINDO À                  \       | \ ",
               @"  >      VRUUM AIRLINES              >------|  \       ______",
                @"/                                  /       --- \_____/   _|_\____  | ",
               @"/                                  /          \_______ --------- __>-}",
              @"/----------------------------------/              /  \_____|_____/   | ",
              @"                                                  *         | ",
              @"                                                            O ",
              @"                                                                                ",
              @"    |*\       |*\       |*\       |*\       |*\       |*\       |*\",
              @"   |***|     |***|     |***|     |***|     |***|     |***|     |***| ",
              @"     \*/       \*/ ____  \*/       \*/       \*/       \*/       \*/ ",
              @"      |         |  |  |   |         |         |         |         | ",
              @"^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^ ",
              @"                                                                         ",
              @"  ------------------------------------------------        ",
            };
            Console.WindowWidth = 160;
            Console.WriteLine("\n\n");
            foreach (string line in arr)
            {
                System.Console.WriteLine(line);              
            }
            string[] nomes = new string[5], numeros = new String[5];
            DateTime[] datas = new DateTime[5];
            bool dnv = true;
            int contador = 0;
            while (dnv == true) {
                menu : System.Console.WriteLine ("---------- MENU ----------");
                System.Console.WriteLine ("1 - Registrar passagem\n2 - Vizualizar passagens\n0 - Fechar");
                //"registro"  VAI SER USADO COMO CHECKPOINT PARA O CASO DE O USUÁRIO QUISER REGISTRAR UMA NOVA PASSAGEM
                registro : switch (Console.ReadLine ()) {
                    //CASO O USUÁRIO QUEIRA REGISTRAR UMA PASSAGEM
                    case "1":
                        System.Console.Write ("Qual o nome do comprador: ");
                        nomes[contador] = Console.ReadLine ();
                        System.Console.Write ("Número da passagem: ");
                        numeros[contador] = Console.ReadLine ();
                        System.Console.Write ("Data do vôo (dd/mm/aaaa): ");
                        datas[contador] = DateTime.Parse (Console.ReadLine ());
                        //O "dnv"  SERVE COMO UM CHECKPOINT PARA O CASO DE O USUÁRIO TENHA DIGITADO UM NÚMERO INVÁLIDO
                        dnv:
                            contador++;
                        System.Console.WriteLine ("1 - Registrar nova passagem\n2 - Voltar ao menu\n0 - Sair.");
                        switch (Console.ReadLine ()) {
                            case "1":
                                goto registro;
                            case "2":
                                goto menu;
                            case "0":
                                Environment.Exit (0);break;
                            default:
                                System.Console.WriteLine ("Use apenas os números pré definidos");
                                goto dnv;
                        }
                        break;
                    //CASO O USUÁRIO QUEIRA VER AS PASSAGENS REGISTRADAS NA SESSÃO
                    case "2":
                        for (int i = 0; i < contador; i++) {
                            System.Console.WriteLine ($"---------- Passagem {i+1} ---------- \nComprador: {nomes[i]}\nNúmero: {numeros[i]}\nData do vôo: {datas[i]:dd/MM/yyyy} {datas[i].Hour} horas");
                        }
                        System.Console.WriteLine ("1 - Registrar nova passagem\n2 - Voltar ao menu\n0 - Sair.");
                        switch (Console.ReadLine ()) {
                            case "1":
                                goto registro;
                            case "2":
                                goto menu;
                            case "0":
                                Environment.Exit (0);break;
                            default:
                                System.Console.WriteLine ("Use apenas os números pré definidos");
                                goto dnv;
                        }
                        break;
                    case "0":Environment.Exit(0);break;

                    default: 
                    System.Console.WriteLine("Ocorreu um erro inesperado.\n1 - Voltar ao menu\n0 - Sair");
                    if(Console.ReadLine().Equals("1")){
                        goto menu;
                    }if(Console.ReadLine().Equals("0")){
                        Environment.Exit(0);
                    }
                    break;
                }
            }
        }
    }
}

using System;

namespace desafio {
    class Program {
        static void Main (string[] args) {
            Console.WriteLine ("Lembre-se que ímpar possue acento e use a primeira letra maiúscula sempre. \nVocê quer jogar par ou ímpar? ");
            string jogo = Console.ReadLine ();
            if (jogo.Equals ("Sim",StringComparison.CurrentCultureIgnoreCase)) {
                inicio : 

                Console.WriteLine ("Escolha par ou impar:");
                string escolha = Console.ReadLine ();
                Random r = new Random ();
                int numeroComputador = r.Next (0, 10);
                Console.WriteLine ("Digite um número de 0 a 10");
                int numeroUsuario = Convert.ToInt32 (Console.ReadLine ());
                Console.WriteLine("O número do computador foi: "+numeroComputador);
                int resultado = (numeroComputador + numeroUsuario) % 2;
                switch (escolha) {
                    case "par":
                        if (resultado == 0) {
                            Console.WriteLine ("Você ganhou! Quer jogar novamente?");
                            jogo = Console.ReadLine ();
                            if (jogo.Equals ("Sim")) {
                                goto inicio;
                            } else {
                                break;
                            }
                        } else {
                            Console.WriteLine ("Você perdeu! Quer jogar novamente?");
                            jogo = Console.ReadLine ();
                            if (jogo.Equals ("Sim")) {
                                goto inicio;
                            } else {
                                break;
                            }
                        }

                    case "Ímpar":
                        if (resultado == 0) {
                            Console.WriteLine ("Você perdeu! Quer jogar novamente?");
                            jogo = Console.ReadLine ();
                            if (jogo.Equals ("Sim")) {
                                goto inicio;
                            } else {
                                break;
                            }
                        } else {
                            Console.WriteLine ("Você ganhou! Quer jogar novamente?");
                            jogo = Console.ReadLine ();
                            if (jogo.Equals ("Sim")) {
                                goto inicio;
                            } else {
                                break;
                            }
                        }
                }

            }
        }
    }
}
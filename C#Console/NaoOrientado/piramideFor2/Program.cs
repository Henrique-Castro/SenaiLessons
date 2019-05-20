using System;

namespace piramideFor2 {
    class Program {
        static void Main (string[] args) {
            System.Console.WriteLine ("Vamos contruir pirâmides?");
            if (Console.ReadLine ().Equals ("Sim", StringComparison.CurrentCultureIgnoreCase)) {
                System.Console.WriteLine ("Quantas pirâmides você quer?");
                int quantidade = int.Parse (Console.ReadLine ());
                System.Console.WriteLine ("Qual o tamanho da pirâmide?");
                int altura = int.Parse (Console.ReadLine ());

                for (int i1 = 1; i1 <= quantidade; i1++) {

                    string estrela = "";
                    for (int i2 = 0; i2 <= altura; i2++) {
                        estrela += "*"; //Sempre que o laço se repetir, o += vai adicionar uma * na variável
                        System.Console.WriteLine (estrela);
                    }

                }

            }
        }
    }
}
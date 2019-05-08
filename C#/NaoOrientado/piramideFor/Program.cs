using System;

namespace piramideFor {
    class Program {
        static void Main (string[] args) {
            System.Console.WriteLine ("Vamos contruir uma pirâmide?");
            if (Console.ReadLine ().Equals ("Sim", StringComparison.CurrentCultureIgnoreCase)) {
                System.Console.WriteLine ("Qual o tamanho da pirâmide?");
                int altura = int.Parse (Console.ReadLine ());

                string estrela = "";

                for (int i = 0; i < altura; i++) {

                    estrela += "*"; //Sempre que o laço se repetir, o += vai adicionar uma * na variável
                    System.Console.WriteLine(estrela);

                }
            }

        }
    }
}
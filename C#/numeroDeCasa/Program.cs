using System;

namespace numeroDeCasa {
    class Program {
        static void Main (string[] args) {

            string[] nomes = new string[5];
            int[] numeros = new int[5];
            bool quero = true;
            for (int i = 0; i < nomes.Length; i++) {
                System.Console.WriteLine ("Qual o seu nome?");
                nomes[i] = Console.ReadLine ();
                System.Console.WriteLine ("Qual o número da sua casa?");
                numeros[i] = int.Parse (Console.ReadLine ());

            }
            System.Console.WriteLine ("Pessoas cadastradas: ");
            
        }
    }
}